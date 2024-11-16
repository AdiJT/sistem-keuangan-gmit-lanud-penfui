using Microsoft.AspNetCore.Mvc;
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
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;

    public RAPBJController(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ,
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Penerimaan(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var rTahun = Tahun.Create(tahun.Value);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);

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

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);

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

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);

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

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);

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

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);

        return View(new RAPBJVM
        {
            Tahun = tahun.Value,
            RAPBJ = rapbj,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == Jenis.Belanja).ToList()
        });
    }
}
