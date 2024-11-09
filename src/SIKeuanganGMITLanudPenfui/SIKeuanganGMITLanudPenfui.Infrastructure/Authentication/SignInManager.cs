using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Infrastructure.Authentication.Contracts;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;
using System.Security.Claims;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Authentication;

internal class SignInManager : ISignInManager
{
    private readonly IRepositoriUser _repositoriUser;
    private readonly HttpContext _httpContext;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly ILogger<SignInManager> _logger;

    public SignInManager(
        IRepositoriUser repositoriUser,
        IHttpContextAccessor httpContextAccessor,
        IPasswordHasher<User> passwordHasher,
        ILogger<SignInManager> logger)
    {
        _repositoriUser = repositoriUser;
        _httpContext = httpContextAccessor.HttpContext!;
        _passwordHasher = passwordHasher;
        _logger = logger;
    }

    public async Task<Result> Login(string username, string password, bool rememberMe)
    {
        //Cek apakah akun ada
        var user = await _repositoriUser.GetByUserName(username);
        if (user is null)
            return new Error("Login.AccountNotFound", $"Account dengan username '{username}' tidak ditemukan");

        //Bandingkan password dengan password di database
        var result = _passwordHasher.VerifyHashedPassword(null, user.PasswordHash, password);
        if (result == PasswordVerificationResult.Failed)
            return new Error("Login.PasswordWrong", "Password yang dimasukkan salah!");

        //Buat claim
        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        //Sign In
        var authProperties = new AuthenticationProperties
        {
            IsPersistent = rememberMe,
        };

        await _httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);

        _logger.LogInformation("{UserName} logged in at {Time} UTC", user.UserName, DateTime.UtcNow);

        return Result.Success();
    }

    public async Task Logout()
    {
        await _httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
