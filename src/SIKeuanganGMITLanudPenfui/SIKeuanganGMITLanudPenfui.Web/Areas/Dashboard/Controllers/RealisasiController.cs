using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.CreateKas;
using SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.EditKas;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.HapusTransaksi;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
public class RealisasiController : Controller
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IFileUploadService _fileUploadService;
    private readonly IFileService _fileService;
    private readonly ISender _sender;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IUnitOfWork _unitOfWork;

    public RealisasiController(
        IRepositoriTransaksi repositoriTransaksi,
        IFileUploadService fileUploadService,
        IFileService fileService,
        ISender sender,
        IRepositoriKas repositoriKas,
        IUnitOfWork unitOfWork)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _fileUploadService = fileUploadService;
        _fileService = fileService;
        _sender = sender;
        _repositoriKas = repositoriKas;
        _unitOfWork = unitOfWork;
    }

    [Route("/[area]/[controller]/{jenis:required}/{tahun:int?}")]
    public async Task<IActionResult> Transaksi(Jenis jenis, int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var daftarTransaksi = await _repositoriTransaksi.GetAllByTahun(tahun.Value, jenis);

        return View(new IndexVM
        {
            Tahun = tahun.Value,
            Jenis = jenis,
            DaftarTransaksi = daftarTransaksi.OrderBy(p => p.Tanggal).ToList()
        });
    }

    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]")]
    public IActionResult Tambah(Jenis jenis, int tahun)
    {
        return View(new TambahVM
        {
            Jenis = jenis,
            Tahun = tahun
        });
    }

    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]")]
    public async Task<IActionResult> Tambah([FromRoute]Jenis jenis, [FromRoute]int tahun, [FromForm]TambahVM vm)
    {
        if(!ModelState.IsValid) return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun) return BadRequest();

        if (vm.Tanggal.Year != vm.Tahun)
        {
            ModelState.AddModelError(nameof(TambahVM.Tanggal), "Tahun salah");
            return View(vm);
        }

        var fileBukti = await _fileUploadService.UploadFile<TambahVM>(
            vm.FileBukti,
            "/filebukti",
            [".pdf", ".docx", ".jpg", ".jpeg"],
            long.MinValue,
            long.MaxValue);

        if(fileBukti.IsFailure)
        {
            ModelState.AddModelError(nameof(TambahVM.FileBukti), fileBukti.Error.Message);
            return View(vm);
        }

        var command = new CreateTransaksiCommand(
            vm.Tanggal,
            vm.Jam,
            vm.Uraian,
            vm.Jumlah,
            fileBukti.Value,
            vm.Jenis,
            vm.IdAkun,
            vm.IdKas);

        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Transaksi), new { jenis, tahun });
    }

    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Edit(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();
        if (transaksi.Tanggal.Year != tahun) return BadRequest();

        return View(new EditVM
        {
            IdTransaksi = id,
            Uraian = transaksi.Uraian,
            IdAkun = transaksi.Akun.Id,
            Jenis = jenis,
            Tahun = tahun,
        });
    }

    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Edit([FromRoute]Jenis jenis, [FromRoute]int tahun, [FromRoute] int id, [FromForm]EditVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun || vm.IdTransaksi != id) return BadRequest();

        var command = new EditTransaksiCommand(vm.IdTransaksi, vm.Uraian, vm.IdAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Transaksi), new { tahun, jenis });
    }

    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Hapus(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

        var command = new HapusTransaksiCommand(id);
        var result = await _sender.Send(command);
        if (result.IsFailure) return BadRequest(result.Error.Message);

        return RedirectToAction(nameof(Transaksi), new { jenis, tahun });
    }

    [Route("/[area]/[controller]/[action]")]
    public async Task<IActionResult> Kas()
    {
        var daftarKas = await _repositoriKas.GetAll();
        return View(daftarKas);
    }

    [Route("/[area]/[controller]/Kas/Tambah")]
    public IActionResult TambahKas()
    {
        return View(new TambahKasVM());
    }

    [HttpPost]
    [Route("/[area]/[controller]/Kas/Tambah")]
    public async Task<IActionResult> TambahKas(TambahKasVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var command = new CreateKasCommand(vm.Uraian, vm.Saldo);
        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Kas));
    }

    [Route("/[area]/[controller]/Kas/Edit/{id:int}")]
    public async Task<IActionResult> EditKas(int id)
    {
        var kas = await _repositoriKas.Get(id);
        if (kas is null) return NotFound();

        return View(new EditKasVM
        {
            IdKas = kas.Id,
            Uraian = kas.Uraian
        });
    }

    [HttpPost]
    [Route("/[area]/[controller]/Kas/Edit/{id:int}")]
    public async Task<IActionResult> EditKas(EditKasVM vm, int id)
    {
        if (!ModelState.IsValid) return View(vm);

        if (vm.IdKas != id) return BadRequest();

        var command = new EditKasCommand(vm.IdKas, vm.Uraian);
        var result = await _sender.Send(command);

        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Kas));
    }

    [HttpPost]
    [Route("/[area]/[controller]/Kas/Hapus/{id:int}")]
    public async Task<IActionResult> HapusKas(int id)
    {
        var kas = await _repositoriKas.Get(id);
        if(kas is null) return NotFound();

        _repositoriKas.Delete(kas);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure) return BadRequest(result.Error.Message);

        return RedirectToAction(nameof(Kas));
    }
}
