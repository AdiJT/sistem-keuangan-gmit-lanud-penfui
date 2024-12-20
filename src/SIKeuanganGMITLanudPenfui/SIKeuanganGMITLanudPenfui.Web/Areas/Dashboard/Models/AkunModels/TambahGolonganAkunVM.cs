﻿using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class TambahGolonganAkunVM
{
    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Uraian { get; set; } = string.Empty;

    [Display(Name = "Kelompok Akun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int IdKelompokAkun { get; set; }

    [Display(Name = "Kode")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public int Kode { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Required]
    public required string ReturnURL { get; set; }
}
