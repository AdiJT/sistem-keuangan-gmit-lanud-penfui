using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Authentication.Contracts;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.HomeModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class HomeController : Controller
{
    private readonly ISignInManager _signInManager;
    private readonly IRepositoriTransaksi _repositoriTransaksi;

    public HomeController(ISignInManager signInManager, IRepositoriTransaksi repositoriTransaksi)
    {
        _signInManager = signInManager;
        _repositoriTransaksi = repositoriTransaksi;
    }

    public async Task<IActionResult> Index()
    {
        var daftarTransaksi = await _repositoriTransaksi.GetAll();

        return View(new IndexVM { DaftarTransaksi = daftarTransaksi });
    }

    [AllowAnonymous]
    [Route("[area]/[action]")]
    public IActionResult Login(string? returnUrl = null)
    {
        return View(new LoginVM
        {
            ReturnUrl = returnUrl ?? Url.Action("Index")!,
        });
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("[area]/[action]")]
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
        return RedirectToAction("Index", "Home", new {Area=""});
    }
}
