using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Models.HomeModels;
using System.Diagnostics;

namespace SIKeuanganGMITLanudPenfui.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRepositoriTransaksi _repositoriTransaksi;

        public HomeController(ILogger<HomeController> logger, IRepositoriTransaksi repositoriTransaksi)
        {
            _logger = logger;
            _repositoriTransaksi = repositoriTransaksi;
        }

        public async Task<IActionResult> Index()
        {
            var daftarTransaksi = await _repositoriTransaksi.GetAll();

            return View(new IndexVM { DaftarTransaksi = daftarTransaksi });
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
