﻿using SIKeuanganGMITLanudPenfui.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class EditVM
{
    [Display(Name = "Id")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int IdTransaksi { get; set; }

    [Display(Name = "Uraian")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string Uraian { get; set; }

    [Display(Name = "File Bukti")]
    [Required(ErrorMessage = "{0} harus diupload")]
    public IFormFile FileBukti { get; set; }

    [Display(Name = "Nomor Bukti")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required string NomorBukti { get; set; } = string.Empty;

    [Display(Name = "Akun")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public required int IdAkun { get; set; }

    [Display(Name = "Jenis")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required Jenis Jenis { get; set; }

    [Display(Name = "Tahun")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required int Tahun { get; set; }
}
