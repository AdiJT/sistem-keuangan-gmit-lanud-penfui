using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Dashboard.Models.LaporanModels;

namespace SIKeuanganGMITLanudPenfui.Web.Controllers;

public class LaporanController : Controller
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IRepositoriKas _repositoriKas;

    public LaporanController(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriTransaksi repositoriTransaksi,
        IRepositoriKas repositoriKas)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriTransaksi = repositoriTransaksi;
        _repositoriKas = repositoriKas;
    }

    public async Task<IActionResult> Index()
    {
        var daftarTransaksi = await _repositoriTransaksi.GetAll();
        var daftarKas = await _repositoriKas.GetAll();

        return View(new IndexVM { DaftarTransaksi = daftarTransaksi, DaftarKas = daftarKas});
    }
}