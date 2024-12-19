using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class LunaskanVM
{
    [Display(Name = "Id")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int IdTransaksi { get; set; }

    [Display(Name = "Jumlah")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} tidak boleh negatif")]
    public required double Jumlah { get; set; }

    [Display(Name = "File Bukti")]
    [Required(ErrorMessage = "{0} harus diupload")]
    public IFormFile FileBukti { get; set; }

    [Display(Name = "Nomor Bukti")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string NomorBukti { get; set; } = string.Empty;

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }
}
