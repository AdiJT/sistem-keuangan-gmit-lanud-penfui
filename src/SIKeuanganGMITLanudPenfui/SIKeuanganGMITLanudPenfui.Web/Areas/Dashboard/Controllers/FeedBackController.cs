using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
public class FeedBackController : Controller
{
    private readonly IRepositoriFeedBack _repositoriFeedBack;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IToastrNotificationService _notificationService;

    public FeedBackController(
        IRepositoriFeedBack repositoriFeedBack,
        IUnitOfWork unitOfWork,
        IToastrNotificationService notificationService)
    {
        _repositoriFeedBack = repositoriFeedBack;
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index()
    {
        var daftarFeedBack = await _repositoriFeedBack.GetAll();

        return View(daftarFeedBack);
    }

    [HttpPost] 
    public async Task<IActionResult> Hapus(int id)
    {
        var feedBack = await _repositoriFeedBack.Get(id);
        if (feedBack is null) return NotFound();

        _repositoriFeedBack.Delete(feedBack);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Hapus Umpan Balik Gagal",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        else
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Hapus Umpan Balik Berhasil",
                Type = ToastrNotificationType.Success
            });

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> MarkAsRead(int id, string? url = null)
    {
        url ??= Url.Action(nameof(Index))!;

        var feedBack = await _repositoriFeedBack.Get(id);
        if (feedBack is null) return NotFound();

        feedBack.SudahDibaca = true;
        _repositoriFeedBack.Update(feedBack);

        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Umpan Balik Gagal Ditandai Sudah Dibaca",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        else
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Umpan Balik Ditandai Sudah Dibaca",
                Type = ToastrNotificationType.Success
            });

        return Redirect(url);
    }

    [HttpPost]
    public async Task<IActionResult> MarkAllAsRead(string? url = null)
    {
        url ??= Url.Action(nameof(Index))!;

        var daftarFeedBack = await _repositoriFeedBack.GetAllUnread();

        foreach(var feedBack in daftarFeedBack)
        {
            feedBack.SudahDibaca = true;
            _repositoriFeedBack.Update(feedBack);
        }

        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Umpan Balik Gagal Ditandai Sudah Dibaca",
                Message = result.Error.Message,
                Type = ToastrNotificationType.Error
            });
        else
            _notificationService.AddNotification(new ToastrNotification
            {
                Title = "Umpan Balik Ditandai Sudah Dibaca",
                Type = ToastrNotificationType.Success
            });

        return Redirect(url);
    }
}
