using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class TambahAkunVM
{
    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Setoran Sinode")]
    [Range(0, 100, ErrorMessage = "{0} harus antara {1}% dan {2}%")]
    public int? PresentaseSetoranSinode { get; set;}

    [Required]
    public required string ReturnURL { get; set; }

    [Display(Name = "Jenis Akun")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public int IdJenisAkun { get; set; }

    [Display(Name = "Kelompok Akun")]
    public int? IdKelompokAkun { get; set; }

    [Display(Name = "Golongan Akun")]
    public int? IdGolonganAkun { get; set; }

    public List<JenisAkun> DaftarJenisAkun { get; set; } = [];
}