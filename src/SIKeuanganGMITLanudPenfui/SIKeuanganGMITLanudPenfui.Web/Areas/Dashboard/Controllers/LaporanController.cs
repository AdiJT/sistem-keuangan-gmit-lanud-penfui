using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.LaporanModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class LaporanController : Controller
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;

    public LaporanController(IRepositoriJenisAkun repositoriJenisAkun, IRepositoriRAPBJ repositoriRAPBJ)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriRAPBJ = repositoriRAPBJ;
    }

    public async Task<IActionResult> RAPBJ(int? tahun = null)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return View(new RAPBJVM
        {
            Tahun = rTahun.Value.Value,
            RAPBJ = rapbj,
            DaftarJenisAkunBelanja = [],
            DaftarJenisAkunPenerimaan = []
        });

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(rTahun.Value);

        return View(new RAPBJVM
        {
            DaftarJenisAkunPenerimaan = daftarJenisAkun.Where(j => j.Jenis == Jenis.Penerimaan).OrderBy(j => j.Kode).ToList(),
            DaftarJenisAkunBelanja = daftarJenisAkun.Where(j => j.Jenis == Jenis.Belanja).OrderBy(j => j.Kode).ToList(),
            RAPBJ = rapbj,
            Tahun = rTahun.Value.Value
        });
    }

    //public async Task<IActionResult> RAPBJPDF(int? tahun = null)
    //{
    //    var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
    //    if (rTahun.IsFailure) return BadRequest();

    //    var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
    //    if (rapbj is null) return NotFound();

    //    var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(rTahun.Value);

    //    var vm = new RAPBJVM
    //    {
    //        DaftarJenisAkunPenerimaan = daftarJenisAkun.Where(j => j.Jenis == Jenis.Penerimaan).OrderBy(j => j.Kode).ToList(),
    //        DaftarJenisAkunBelanja = daftarJenisAkun.Where(j => j.Jenis == Jenis.Belanja).OrderBy(j => j.Kode).ToList(),
    //        RAPBJ = rapbj
    //    });

    //    var html = await RazorTemplateEngine
    //}
}