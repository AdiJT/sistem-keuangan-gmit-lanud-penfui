using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.CreateKas;
using SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.EditKas;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateBelanjaPanjar;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.HapusTransaksi;
using SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.MelunaskanPanjar;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
public class RealisasiController : Controller
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IFileUploadService _fileUploadService;
    private readonly IFileService _fileService;
    private readonly ISender _sender;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IToastrNotificationService _notificationService;

    public RealisasiController(
        IRepositoriTransaksi repositoriTransaksi,
        IFileUploadService fileUploadService,
        IFileService fileService,
        ISender sender,
        IRepositoriKas repositoriKas,
        IUnitOfWork unitOfWork,
        IToastrNotificationService notificationService)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _fileUploadService = fileUploadService;
        _fileService = fileService;
        _sender = sender;
        _repositoriKas = repositoriKas;
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int?}")]
    public async Task<IActionResult> Transaksi(Jenis jenis, int? tahun = null, DateOnly? start = null, DateOnly? end = null)
    {
        tahun ??= DateTime.Now.Year;

        if (start is null || start.Value.Year != tahun)
            start = new DateOnly(tahun.Value, 1, 1);

        if (end is null || end.Value.Year != tahun)
            end = new DateOnly(tahun.Value, 12, 31);

        var daftarTransaksi = (await _repositoriTransaksi.GetAllByTahun(tahun.Value, jenis))
            .Where(t => DateOnly.FromDateTime(t.Tanggal) >= start.Value && DateOnly.FromDateTime(t.Tanggal) <= end.Value)
            .ToList();

        return View(new TransaksiVM
        {
            Tahun = tahun.Value,
            Jenis = jenis,
            DaftarTransaksi = daftarTransaksi.OrderBy(p => p.Tanggal).ToList(),
            Start = start.Value,
            End = end.Value
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]")]
    public IActionResult Tambah(Jenis jenis, int tahun)
    {
        return View(new TambahVM
        {
            Jenis = jenis,
            Tahun = tahun
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]")]
    public async Task<IActionResult> Tambah([FromRoute] Jenis jenis, [FromRoute] int tahun, [FromForm] TambahVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

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

        if (fileBukti.IsFailure)
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
            vm.NomorBukti,
            vm.Jenis,
            vm.IdAkun,
            vm.IdKas);

        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Transaksi baru sukses ditambahkan");

        return RedirectToAction(nameof(Transaksi), new { jenis, tahun });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Edit(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();
        if (transaksi.Tanggal.Year != tahun) return BadRequest();

        return View(new EditVM
        {
            IdTransaksi = id,
            NomorBukti = transaksi.NomorBukti!,
            Uraian = transaksi.Uraian,
            IdAkun = transaksi.Akun.Id,
            Jenis = jenis,
            Tahun = tahun
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Edit([FromRoute] Jenis jenis, [FromRoute] int tahun, [FromRoute] int id, [FromForm] EditVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun || vm.IdTransaksi != id) return BadRequest();

        var fileBukti = await _fileUploadService.UploadFile<TambahVM>(
           vm.FileBukti,
           "/filebukti",
           [".pdf", ".docx", ".jpg", ".jpeg"],
           long.MinValue,
           long.MaxValue);

        if (fileBukti.IsFailure)
        {
            ModelState.AddModelError(nameof(TambahVM.FileBukti), fileBukti.Error.Message);
            return View(vm);
        }

        var command = new EditTransaksiCommand(vm.IdTransaksi, vm.Uraian, fileBukti.Value, vm.NomorBukti, vm.IdAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Transaksi sukses diubah");

        return RedirectToAction(nameof(Transaksi), new { tahun, jenis });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/{jenis:required}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> Hapus(Jenis jenis, int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

        var command = new HapusTransaksiCommand(id);
        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus {jenis} gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus {jenis} Berhasil",
                Message = $"{jenis} '{transaksi.Uraian}' berhasil dihapus",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Transaksi), new {tahun, jenis});
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/[action]")]
    public async Task<IActionResult> Kas()
    {
        var daftarKas = await _repositoriKas.GetAll();
        return View(daftarKas);
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}")]
    [Route("/[area]/[controller]/Kas/Tambah")]
    public IActionResult TambahKas()
    {
        return View(new TambahKasVM());
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}")]
    [HttpPost]
    [Route("/[area]/[controller]/Kas/Tambah")]
    public async Task<IActionResult> TambahKas(TambahKasVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var command = new CreateKasCommand(vm.Uraian, vm.Saldo, vm.Keterangan);
        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Kas baru sukses ditambahkan");

        return RedirectToAction(nameof(Kas));
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}")]
    [Route("/[area]/[controller]/Kas/Edit/{id:int}")]
    public async Task<IActionResult> EditKas(int id)
    {
        var kas = await _repositoriKas.Get(id);
        if (kas is null) return NotFound();

        return View(new EditKasVM
        {
            IdKas = kas.Id,
            Uraian = kas.Uraian,
            Keterangan = kas.Keterangan,
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}")]
    [HttpPost]
    [Route("/[area]/[controller]/Kas/Edit/{id:int}")]
    public async Task<IActionResult> EditKas(EditKasVM vm, int id)
    {
        if (!ModelState.IsValid) return View(vm);

        if (vm.IdKas != id) return BadRequest();

        var command = new EditKasCommand(vm.IdKas, vm.Uraian, vm.Keterangan);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Kas sukses diubah");

        return RedirectToAction(nameof(Kas));
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}")]
    [HttpPost]
    [Route("/[area]/[controller]/Kas/Hapus/{id:int}")]
    public async Task<IActionResult> HapusKas(int id)
    {
        var kas = await _repositoriKas.Get(id);
        if (kas is null) return NotFound();

        _repositoriKas.Delete(kas);
        var result = await _unitOfWork.SaveChangesAsync();

        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus Kas Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus Kas Berhasil",
                Message = $"Kas {kas.Uraian} berhasil dihapus",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Kas));
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/[action]/{tahun:int?}")]
    public async Task<IActionResult> Panjar(int? tahun = null, DateOnly? start = null, DateOnly? end = null)
    {
        tahun ??= DateTime.Now.Year;

        if (start is null || start.Value.Year != tahun)
            start = new DateOnly(tahun.Value, 1, 1);

        if (end is null || end.Value.Year != tahun)
            end = new DateOnly(tahun.Value, 12, 31);

        var daftarTransaksi = (await _repositoriTransaksi.GetAllPanjarByTahun(tahun.Value))
            .Where(t => DateOnly.FromDateTime(t.Tanggal) >= start.Value && DateOnly.FromDateTime(t.Tanggal) <= end.Value)
            .ToList();

        return View(new PanjarVM
        {
            Tahun = tahun.Value,
            DaftarTransaksi = daftarTransaksi.OrderBy(p => p.Tanggal).ToList(),
            Start = start.Value,
            End = end.Value
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/[action]/{tahun:int}")]
    public IActionResult TambahPanjar(int tahun)
    {
        return View(new TambahPanjarVM { Tahun = tahun });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/[action]/{tahun:int}")]
    public async Task<IActionResult> TambahPanjar([FromRoute] int tahun, TambahPanjarVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if (tahun != vm.Tahun) return BadRequest();

        if (vm.Tanggal.Year != vm.Tahun)
        {
            ModelState.AddModelError(nameof(TambahVM.Tanggal), "Tahun salah");
            return View(vm);
        }

        var command = new CreateBelanjaPanjarCommand(
            vm.Tanggal,
            vm.Jam,
            vm.Uraian,
            vm.Jumlah,
            vm.IdAkun,
            vm.IdKas);

        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Panjar baru sukses ditambah");

        return RedirectToAction(nameof(Panjar), new { tahun });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/[action]/{tahun:int}/{id:int}")]
    public async Task<IActionResult> EditPanjar(int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();
        if (transaksi.Tanggal.Year != tahun || transaksi.Jenis != Jenis.Belanja || transaksi.StatusTransaksi != StatusTransaksi.Panjar)
            return BadRequest();

        return View(new EditPanjarVM
        {
            IdTransaksi = id,
            Uraian = transaksi.Uraian,
            IdAkun = transaksi.Akun.Id,
            Tahun = tahun
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/[action]/{tahun:int}/{id:int}")]
    public async Task<IActionResult> EditPanjar([FromRoute] int tahun, [FromRoute] int id, EditPanjarVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if (tahun != vm.Tahun || vm.IdTransaksi != id)
            return BadRequest();

        var command = new EditTransaksiCommand(vm.IdTransaksi, vm.Uraian, new Uri("https://filebukti.com/1") , string.Empty, vm.IdAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Panjar sukses diubah");

        return RedirectToAction(nameof(Panjar), new { tahun });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusPanjar(int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

        var command = new HapusTransaksiCommand(id);
        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus Panjar gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus Panjar Berhasil",
                Message = $"Panjar '{transaksi.Uraian}' berhasil dihapus",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Panjar), new {tahun});
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [Route("/[area]/[controller]/[action]/{tahun:int}/{id:int}")]
    public async Task<IActionResult> Lunaskan(int tahun, int id)
    {
        var transaksi = await _repositoriTransaksi.Get(id);
        if (transaksi is null) return NotFound();

        if (transaksi.Tanggal.Year != tahun || transaksi.Jenis != Jenis.Belanja || transaksi.StatusTransaksi != StatusTransaksi.Panjar)
            return BadRequest();

        return View(new LunaskanVM
        {
            IdTransaksi = id,
            Jumlah = transaksi.Jumlah,
            Tahun = tahun,
        });
    }

    [Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
    [HttpPost]
    [Route("/[area]/[controller]/[action]/{tahun:int}/{id:int}")]
    public async Task<IActionResult> Lunaskan(int tahun, int id, LunaskanVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if (tahun != vm.Tahun || id != vm.IdTransaksi) return BadRequest();

        var fileBukti = await _fileUploadService.UploadFile<LunaskanVM>(
           vm.FileBukti,
           "/filebukti",
           [".pdf", ".docx", ".jpg", ".jpeg"],
           long.MinValue,
           long.MaxValue);

        if (fileBukti.IsFailure)
        {
            ModelState.AddModelError(nameof(TambahVM.FileBukti), fileBukti.Error.Message);
            return View(vm);
        }

        var command = new MelunaskanPanjarCommand(vm.IdTransaksi, vm.Jumlah, fileBukti.Value, vm.NomorBukti);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Transaksi berhasil dilunaskan");

        return RedirectToAction(nameof(Panjar), new { tahun });
    }
}