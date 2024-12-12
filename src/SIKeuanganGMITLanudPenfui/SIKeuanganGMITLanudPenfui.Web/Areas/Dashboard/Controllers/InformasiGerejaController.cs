using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.CreateInformasiGereja;
using SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.EditInformasiGereja;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.InformasiGerejaModels;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Authorize]
[Area("Dashboard")]
public class InformasiGerejaController : Controller
{
    private readonly IRepositoriInformasiGereja _repositoriInformasiGereja;
    private readonly ISender _sender;
    private readonly IToastrNotificationService _notificationService;

    public InformasiGerejaController(
        IRepositoriInformasiGereja repositoriInformasiGereja,
        ISender sender,
        IToastrNotificationService notificationService)
    {
        _repositoriInformasiGereja = repositoriInformasiGereja;
        _sender = sender;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index(int? tahun)
    {
        tahun ??= DateTime.Now.Year;
        var rTahun = Tahun.Create(tahun.Value);

        var informasiGereja = await _repositoriInformasiGereja.Get(rTahun.Value);

        return View(new IndexVM { Tahun = tahun.Value, InformasiGereja = informasiGereja });
    }

    public IActionResult Tambah(int tahun)
    {
        return View(new TambahVM { Tahun = tahun });
    }

    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if(!ModelState.IsValid) return View(vm);

        var command = new CreareInformasiGerejaCommand(vm.Tahun, vm.KetuaMajelisJemaat, vm.Bendahara);
        var result = await _sender.Send(command);

        if(result.IsFailure)
        {
            _notificationService.AddError("Gagal Menambah Informasi Gereja!", result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Informasi Gereja Sukses Ditambahkan");

        return RedirectToAction(nameof(Index), new {tahun = vm.Tahun});
    }

    public async Task<IActionResult> Edit(int tahun)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var informasiGereja = await _repositoriInformasiGereja.Get(rTahun.Value);
        if (informasiGereja is null) return NotFound();

        return View(new EditVM
        {
            Tahun = tahun,
            Bendahara = informasiGereja.Bendahara,
            KetuaMajelisJemaat = informasiGereja.KetuaMajelisJemaat
        });
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var command = new EditInformasiGerejaCommand(vm.Tahun, vm.KetuaMajelisJemaat, vm.Bendahara);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            _notificationService.AddError("Gagal Edit Informasi Gereja!", result.Error.Message);
            return View(vm);
        }

        _notificationService.AddSuccess("Informasi Gereja Sukses Diedit");

        return RedirectToAction(nameof(Index), new { tahun = vm.Tahun });
    }
}
