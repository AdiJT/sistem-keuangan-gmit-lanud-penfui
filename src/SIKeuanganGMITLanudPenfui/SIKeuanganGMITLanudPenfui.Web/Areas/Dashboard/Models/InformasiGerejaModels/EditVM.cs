using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.InformasiGerejaModels;

public class EditVM
{
    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Ketua Majelis Jemaat (KMJ)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string KetuaMajelisJemaat { get; set; }

    [Display(Name = "Bendahara")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string Bendahara { get; set; }
}
