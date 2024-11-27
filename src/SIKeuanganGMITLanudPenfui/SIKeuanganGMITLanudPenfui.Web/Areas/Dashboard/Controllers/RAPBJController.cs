using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.AddAllAkun;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateDetailRAPBJ;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateRAPBJ;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteDetailRAPBJ;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteRAPBJ;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.EditDetailRAPBJ;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RAPBJModels;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class RAPBJController : Controller
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly ISender _sender;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IToastrNotificationService _notificationService;

    public RAPBJController(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ,
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IUnitOfWork unitOfWork,
        ISender sender,
        IToastrNotificationService notificationService)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _unitOfWork = unitOfWork;
        _sender = sender;
        _notificationService = notificationService;
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int?}")]
    public async Task<IActionResult> Index(Jenis jenis, int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;
        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new IndexVM
        {
            Tahun = tahun.Value,
            Jenis = jenis,
            RAPBJ = rapbj
        });
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahDetailRAPBJ(Jenis jenis, int tahun)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return NotFound();

        return View(new TambahDetailRAPBJVM
        {
            Tahun = tahun,
            Jenis = jenis
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahDetailRAPBJ(
        [FromRoute] Jenis jenis,
        [FromRoute] int tahun,
        [FromForm] TambahDetailRAPBJVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun) return BadRequest();

        var command = new CreateDetailRAPBJCommand(vm.Tahun, vm.IdAkun, vm.Volume, vm.Satuan, vm.HargaSatuan);
        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditDetailRAPBJ(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return NotFound();

        var detailRAPBJ = rapbj.DaftarDetailRAPBJ.FirstOrDefault(d => d.Akun.Id == id);
        if (detailRAPBJ is null) return NotFound();

        return View(new EditDetailRAPBJVM
        {
            Tahun = tahun,
            Jenis = jenis,
            IdAkun = id,
            HargaSatuan = detailRAPBJ.HargaSatuan,
            Satuan = detailRAPBJ.Satuan,
            Volume = detailRAPBJ.Volume,
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> EditDetailRAPBJPOST(
        [FromRoute] Jenis jenis,
        [FromRoute] int tahun,
        [FromForm] EditDetailRAPBJVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        if (jenis != vm.Jenis || tahun != vm.Tahun) return BadRequest();

        var command = new EditDetailRAPBJCommand(tahun, vm.IdAkun, vm.Volume, vm.Satuan, vm.HargaSatuan);
        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(vm);
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }


    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusDetailRAPBJ(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var command = new DeleteDetailRAPBJCommand(tahun, id);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Hapus Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Hapus Berhasil",
                Message = "Akun berhasil dihapus dari RAPBJ",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahRAPBJ(Jenis jenis, int tahun)
    {
        var command = new CreateRAPBJCommand(tahun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Tambah RAPBJ Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Tambah RAPBJ Berhasil",
                Message = $"RAPBJ Tahun {tahun} berhasil dibuat",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahSemuaAkun(Jenis jenis, int tahun)
    {
        var command = new AddAllAkunCommand(tahun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Tambah Semua Akun ke RAPBJ Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Tambah Semua Akun ke RAPBJ Berhasil",
                Message = $"Semua akun tahun {tahun} berhasil dimasukkan ke RAPBJ tahun {tahun}",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> HapusRAPBJ(Jenis jenis, int tahun)
    {
        var command = new DeleteRAPBJCommand(tahun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus RAPBJ tahun {tahun} Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        }
        else
        {
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = $"Hapus RAPBJ tahun {tahun} Berhasil",
                Message = $"RAPBJ tahun {tahun} berhasil dihapus",
                Type = ToastrNotificationType.Success
            });
        }

        return RedirectToAction(nameof(Index), new { jenis, tahun });
    }
}
