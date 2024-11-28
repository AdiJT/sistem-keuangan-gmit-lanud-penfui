using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Models.HomeModels;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;
using System.Diagnostics;

namespace SIKeuanganGMITLanudPenfui.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoriTransaksi _repositoriTransaksi;
        private readonly IRepositoriFeedBack _repositoriFeedBack;
        private readonly IToastrNotificationService _notificationService;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(
            ILogger<HomeController> logger,
            IRepositoriTransaksi repositoriTransaksi,
            IRepositoriFeedBack repositoriFeedBack,
            IToastrNotificationService notificationService,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _repositoriTransaksi = repositoriTransaksi;
            _repositoriFeedBack = repositoriFeedBack;
            _notificationService = notificationService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var daftarTransaksi = await _repositoriTransaksi.GetAll();

            return View(new IndexVM { DaftarTransaksi = daftarTransaksi });
        }

        [HttpPost]
        public async Task<IActionResult> Index(IndexVM vm)
        {
            if (!ModelState.IsValid)
            {
                _notificationService.AddNotification(new ToastrNotification
                {
                    Title = "Kirim Pesan Gagal",
                    Message = "Terdapat error pada data yang dimasukkan",
                    Type = ToastrNotificationType.Error
                });

                return RedirectToAction(nameof(Index));
            }

            var feedBack = new FeedBack
            {
                Judul = vm.Judul,
                Nama = vm.Nama,
                Pesan = vm.Pesan,
                Tanggal = DateTime.Now,
                SudahDibaca = false
            };
            _repositoriFeedBack.Add(feedBack);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result.IsFailure)
                _notificationService.AddNotification(new ToastrNotification
                {
                    Title = "Kirim Pesan Gagal",
                    Message = result.Error.Message,
                    Type = ToastrNotificationType.Error
                });
            else
                _notificationService.AddNotification(new ToastrNotification
                {
                    Title = "Kirim Pesan Berhasil",
                    Message = "Pesan feedback telah dikirim",
                    Type = ToastrNotificationType.Success
                });

            return RedirectToAction(nameof(Index));
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
