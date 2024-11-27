using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Authentication.Contracts;

public interface ISignInManager
{
    Task<Result> Login(string username, string password, bool rememberMe);
    Task Logout();
    Task<User?> GetUser();
}
