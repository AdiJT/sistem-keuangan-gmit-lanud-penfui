using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.InformasiGerejaModels;

public class TambahVM
{
    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Ketua Majelis Jemaat (KMJ)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string KetuaMajelisJemaat { get; set; } = string.Empty;

    [Display(Name = "Bendahara")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Bendahara { get; set; } = string.Empty;
}
