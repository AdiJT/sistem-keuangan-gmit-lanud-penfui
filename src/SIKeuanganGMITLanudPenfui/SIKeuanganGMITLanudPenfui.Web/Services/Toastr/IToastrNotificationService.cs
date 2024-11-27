using SIKeuanganGMITLanudPenfui.Web.Models;

namespace SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

public interface IToastrNotificationService
{
    string? GetNotificationJson();
    void AddNotification(ToastrNotification notification);
}