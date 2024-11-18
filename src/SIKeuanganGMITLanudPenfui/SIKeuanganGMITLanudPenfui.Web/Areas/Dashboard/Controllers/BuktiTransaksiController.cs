using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
public class BuktiTransaksiController : Controller
{
    private readonly IRepositoriBuktiTransaksi _repositoriBuktiTransaksi;

    public BuktiTransaksiController(IRepositoriBuktiTransaksi repositoriBuktiTransaksi)
    {
        _repositoriBuktiTransaksi = repositoriBuktiTransaksi;
    }

    public async Task<IActionResult> Index()
    {
        var daftarBuktiTransaksi = await _repositoriBuktiTransaksi.GetAll();

        return View(daftarBuktiTransaksi);
    }
}
