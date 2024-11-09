using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
public class AkunController : Controller
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;

    public AkunController(
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
    }

    public async Task<IActionResult> Penerimaan()
    {
        var daftarAkun = await _repositoriAkun.GetAllPenerimaan();
        var daftarJenisAkun = await _repositoriJenisAkun.GetAllPenerimaan();
        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllPenerimaan();
        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllPenerimaan();

        return View(new PenerimaanVM
        {
            DaftarAkun = daftarAkun,
            DaftarJenisAkun = daftarJenisAkun,
            DaftarKelompokAkun = daftarKelompokAkun,
            DaftarGolonganAkun = daftarGolonganAkun
        });
    }

    public async Task<IActionResult> Belanja()
    {
        var daftarAkun = await _repositoriAkun.GetAllBelanja();
        var daftarJenisAkun = await _repositoriJenisAkun.GetAllBelanja();
        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllBelanja();
        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllBelanja();

        return View(new BelanjaVM
        {
            DaftarAkun = daftarAkun,
            DaftarJenisAkun = daftarJenisAkun,
            DaftarKelompokAkun = daftarKelompokAkun,
            DaftarGolonganAkun = daftarGolonganAkun
        });
    }
}
