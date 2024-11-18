using SIKeuanganGMITLanudPenfui.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RAPBJModels;

public class TambahDetailRAPBJVM
{
    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Display(Name = "Akun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int IdAkun { get; set; }

    [Display(Name = "Volume")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} harus lebih besar dari {1} dan lebih kecil dari {2}")]
    public int Volume { get; set; }

    [Display(Name = "Satuan")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Satuan { get; set; } = string.Empty;

    [Display(Name = "Harga Satuan")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} harus lebih besar dari {1} dan lebih kecil dari {2}")]
    public double HargaSatuan { get; set; }
}
