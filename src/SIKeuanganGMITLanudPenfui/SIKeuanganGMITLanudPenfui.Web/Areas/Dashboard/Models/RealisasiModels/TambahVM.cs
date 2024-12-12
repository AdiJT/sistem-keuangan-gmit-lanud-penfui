using SIKeuanganGMITLanudPenfui.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class TambahVM
{
    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Jumlah")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} tidak boleh negatif")]
    public double Jumlah { get; set; }

    [Display(Name = "Tanggal")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public DateOnly Tanggal { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    [Display(Name = "Jam")]
    public TimeOnly? Jam { get; set; }

    [Display(Name = "File Bukti")]
    [Required(ErrorMessage = "{0} harus diupload")]
    public IFormFile FileBukti { get; set; }
    
    [Display(Name = "Nomor Bukti")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string NomorBukti { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Kas")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public int IdKas { get; set; }

    [Display(Name = "Akun")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public int IdAkun { get; set; }
}