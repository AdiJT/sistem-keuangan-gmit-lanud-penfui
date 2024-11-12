using SIKeuanganGMITLanudPenfui.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class TambahJenisAkunVM
{
    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, 2030, ErrorMessage = "{0} harus diantara {1} dan {2}")]
    public required int Tahun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Required]
    public required string ReturnUrl { get; set; }
}