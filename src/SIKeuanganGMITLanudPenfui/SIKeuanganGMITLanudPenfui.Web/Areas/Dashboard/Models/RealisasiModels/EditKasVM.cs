using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class EditKasVM
{
    [Display(Name = "Id")]
    [Required(ErrorMessage = "{0} harus ada")]
    public required int IdKas { get; set; }

    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string Uraian { get; set; }
}
