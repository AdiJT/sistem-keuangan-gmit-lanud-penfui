using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIKeuanganGMITLanudPenfui.Web.Models;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

namespace SIKeuanganGMITLanudPenfui.Web.ViewComponents;

public class ToastrViewComponent : ViewComponent
{
    private readonly IToastrNotificationService _notificationService;

    public ToastrViewComponent(IToastrNotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public IViewComponentResult Invoke(ToastrOptions globalOptions)
    {
        string globalOptionsJson = JsonConvert.SerializeObject(globalOptions, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
        });
        return View((globalOptionsJson, _notificationService.GetNotificationJson()));
    }
}