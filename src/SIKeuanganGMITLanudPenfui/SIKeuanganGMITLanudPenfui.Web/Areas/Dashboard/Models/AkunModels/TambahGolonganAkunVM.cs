using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class TambahGolonganAkunVM
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;

    public TambahGolonganAkunVM(IRepositoriJenisAkun repositoriJenisAkun)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
    }

    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Kelompok Akun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int IdKelompokAkun { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Required]
    public required string ReturnURL { get; set; }

    public async Task<List<JenisAkun>> DaftarJenisAkun() => 
        (await _repositoriJenisAkun.GetAll())
        .Where(j => j.Tahun.Value == Tahun && j.Jenis == Jenis)
        .ToList();
}
