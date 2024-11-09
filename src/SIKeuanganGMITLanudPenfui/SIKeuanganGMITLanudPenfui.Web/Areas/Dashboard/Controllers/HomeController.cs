using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Authentication.Contracts;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.HomeModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class HomeController : Controller
{
    private readonly ISignInManager _signInManager;

    public HomeController(ISignInManager signInManager)
    {
        _signInManager = signInManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public IActionResult Login(string? returnUrl = null)
    {
        return View(new LoginVM
        {
            ReturnUrl = returnUrl ?? Url.Action("Index")!,
        });
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login(LoginVM loginVM)
    {
        if(!ModelState.IsValid) return View(loginVM);

        var result = await _signInManager.Login(loginVM.Username, loginVM.Password, loginVM.RememberMe);

        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, result.Error.Message);
            return View(loginVM);
        }

        return Redirect(loginVM.ReturnUrl);
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.Logout();
        return RedirectToAction("Login");
    }
}
