﻿using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class EditAkunVM
{
    [Display(Name = "Id")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Id { get; set; }

    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string Uraian { get; set; }

    [Display(Name = "Kode")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public required int Kode { get; set; }

    [Display(Name = "Setoran Sinode")]
    public required bool SetoranSinode { get; set; }

    [Display(Name = "Jenis Akun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int IdJenisAkun { get; set; }

    [Display(Name = "Kelompok Akun")]
    public required int? IdKelompokAkun { get; set; }

    [Display(Name = "Golongan Akun")]
    public required int? IdGolonganAkun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }

    [Required(ErrorMessage = "{0} harus diisi")]
    public required string ReturnUrl { get; set; }
}
