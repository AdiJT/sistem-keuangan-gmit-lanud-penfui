using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Web.Models;

namespace SIKeuanganGMITLanudPenfui.Web.ViewComponents;

public class ChartViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ChartVM chartModel)
    {
        return View(chartModel);
    }
}