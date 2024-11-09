using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.HomeModels;

public class LoginVM
{
    [Display(Name = "User Name")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Username { get; set; } = string.Empty;

    [Display(Name = "Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Ingat Saya")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public bool RememberMe { get; set; }

    public string ReturnUrl { get; set; } = string.Empty;
}
