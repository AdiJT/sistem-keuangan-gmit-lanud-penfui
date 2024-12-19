using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class TambahPanjarVM
{
    [Display(Name = "Tanggal")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public DateOnly Tanggal { get; set; }

    [Display(Name = "Jam")]
    public TimeOnly? Jam {  get; set; }

    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Jumlah")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} tidak boleh negatif")]
    public double Jumlah { get; set; }

    [Display(Name = "Akun")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public int IdAkun { get; set; }

    [Display(Name = "Kas")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public int IdKas { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int Tahun { get; set; }
}