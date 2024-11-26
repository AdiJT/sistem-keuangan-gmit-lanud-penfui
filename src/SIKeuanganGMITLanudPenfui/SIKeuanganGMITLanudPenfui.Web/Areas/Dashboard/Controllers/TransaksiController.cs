using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.HapusTransaksi;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.TransaksiModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class TransaksiController : Controller
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IFileUploadService _fileUploadService;
    private readonly IFileService _fileService;
    private readonly ISender _sender;

    public TransaksiController(
        IRepositoriTransaksi repositoriTransaksi,
        IFileUploadService fileUploadService,
        IFileService fileService,
        ISender sender)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _fileUploadService = fileUploadService;
        _fileService = fileService;
        _sender = sender;
    }

    [Route("/[area]/[controller]/{jenis}/{tahun:int?}")]
    public async Task<IActionResult> Index(Jenis jenis, int? tahun = null)
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

    [Route("/[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public IActionResult Tambah(Jenis jenis, int tahun)
    {
        return View(new TambahVM
        {
            Jenis = jenis,
            Tahun = tahun
        });
    }

    [HttpPost]
    [Route("/[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> Tambah([FromRoute]Jenis jenis, [FromRoute]int tahun, [FromForm]TambahVM vm)
    {
        if(!ModelState.IsValid) return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun) return BadRequest();

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

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }

    [Route("/[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Edit(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

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
    [Route("/[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
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

        return RedirectToAction(nameof(Index), new { tahun, jenis });
    }

    [HttpPost]
    [Route("/[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Hapus(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

        var command = new HapusTransaksiCommand(id);
        var result = await _sender.Send(command);
        if (result.IsFailure) return BadRequest(result.Error.Message);

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }
}
