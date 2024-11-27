using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class User : Entity
{
    public string UserName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}

public static class UserRoles
{
    public const string Bendahara = "Bendahara";
    public const string Operator = "Operator";
}