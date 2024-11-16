using MediatR;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateRAPBJ;
using SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteRAPBJ;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RAPBJModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
public class RAPBJController : Controller
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly ISender _sender;
    private readonly IUnitOfWork _unitOfWork;

    public RAPBJController(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ,
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IUnitOfWork unitOfWork,
        ISender sender)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _unitOfWork = unitOfWork;
        _sender = sender;
    }

    public async Task<IActionResult> Penerimaan(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Penerimaan).ToList()
        });
    }

    public async Task<IActionResult> PenerimaanLainnya(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Penerimaan).ToList()
        });
    }

    public async Task<IActionResult> BelanjaRutin(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Belanja).ToList()
        });
    }

    public async Task<IActionResult> BelanjaProgramPelayanan(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Belanja).ToList()
        });
    }

    public async Task<IActionResult> BelanjaLainnya(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Belanja).ToList()
        });
    }

    [HttpPost]
    public async Task<IActionResult> TambahRAPBJ(int tahun, string returnUrl)
    {
        var command = new CreateRAPBJCommand(tahun);
        var result = await _sender.Send(command);

        if (result.IsFailure) return BadRequest();

        return Redirect(returnUrl);
    }

    [HttpPost]
    public async Task<IActionResult> HapusRAPBJ(int tahun, string returnUrl)
    {
        var command = new DeleteRAPBJCommand(tahun);
        var result = await _sender.Send(command);
        if (result.IsFailure) return BadRequest();

        return Redirect(returnUrl);
    }
}
