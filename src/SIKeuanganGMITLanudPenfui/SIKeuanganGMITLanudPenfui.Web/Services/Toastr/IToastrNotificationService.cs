using SIKeuanganGMITLanudPenfui.Web.Models;

namespace SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

public interface IToastrNotificationService
{
    string? GetNotificationJson();
    void AddNotification(ToastrNotification notification);
    void AddSuccess(string message, string? title = null, ToastrOptions? toastrOptions = null);
    void AddInformation(string message, string? title = null, ToastrOptions? toastrOptions = null);
    void AddWarning(string message, string? title = null, ToastrOptions? toastrOptions = null);
    void AddError(string message, string? title = null, ToastrOptions? toastrOptions = null);
}