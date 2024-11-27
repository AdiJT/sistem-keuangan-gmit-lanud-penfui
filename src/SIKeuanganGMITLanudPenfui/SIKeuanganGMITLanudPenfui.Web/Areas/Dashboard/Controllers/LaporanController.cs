using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NReco.PdfGenerator;
using Razor.Templating.Core;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.LaporanModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = $"{UserRoles.Bendahara}, {UserRoles.Operator}")]
public class LaporanController : Controller
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRazorTemplateEngine _razorTemplateEngine;
    private readonly IRepositoriTransaksi _repositoriTransaksi;

    public LaporanController(
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriRAPBJ repositoriRAPBJ,
        IRazorTemplateEngine razorTemplateEngine,
        IRepositoriTransaksi repositoriTransaksi)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriRAPBJ = repositoriRAPBJ;
        _razorTemplateEngine = razorTemplateEngine;
        _repositoriTransaksi = repositoriTransaksi;
    }

    public async Task<IActionResult> RAPBJ(int? tahun = null)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return View(new RAPBJVM
        {
            Tahun = rTahun.Value.Value,
            RAPBJ = rapbj,
            DaftarJenisAkunBelanja = [],
            DaftarJenisAkunPenerimaan = []
        });

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(rTahun.Value);

        return View(new RAPBJVM
        {
            DaftarJenisAkunPenerimaan = daftarJenisAkun.Where(j => j.Jenis == Jenis.Penerimaan).OrderBy(j => j.Kode).ToList(),
            DaftarJenisAkunBelanja = daftarJenisAkun.Where(j => j.Jenis == Jenis.Belanja).OrderBy(j => j.Kode).ToList(),
            RAPBJ = rapbj,
            Tahun = rTahun.Value.Value
        });
    }

    [AllowAnonymous]
    public async Task<IActionResult> RAPBJPDF(int? tahun = null, bool download = false)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return NotFound();

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(rTahun.Value);

        var vm = new RAPBJVM
        {
            DaftarJenisAkunPenerimaan = daftarJenisAkun.Where(j => j.Jenis == Jenis.Penerimaan).OrderBy(j => j.Kode).ToList(),
            DaftarJenisAkunBelanja = daftarJenisAkun.Where(j => j.Jenis == Jenis.Belanja).OrderBy(j => j.Kode).ToList(),
            RAPBJ = rapbj,
            Tahun = rTahun.Value.Value
        };

        var html = await _razorTemplateEngine.RenderAsync("Areas/Dashboard/Views/Laporan/_LaporanRAPBJPartial.cshtml", vm);
        var htmlToPdf = new HtmlToPdfConverter();
        var pdfBinary = htmlToPdf.GeneratePdf(html);

        if (download)
            return File(pdfBinary, "application/pdf", $"RAPBJ - {vm.Tahun}");

        return File(pdfBinary, "application/pdf");
    }

    public async Task<IActionResult> RekaptulasiTahunan(int? tahun = null)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if(rapbj is null) return NotFound();

        var daftarTransaksi = await _repositoriTransaksi.GetAllByTahun(rTahun.Value.Value);

        return View(new RekaptulasiTahunanVM
        {
            DaftarTransaksi = daftarTransaksi,
            Tahun = rTahun.Value.Value,
            RAPBJ = rapbj
        });
    }

    [AllowAnonymous]
    public async Task<IActionResult> RekaptulasiTahunanPDF(int? tahun = null, bool download = false)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return NotFound();

        var daftarTransaksi = await _repositoriTransaksi.GetAllByTahun(rTahun.Value.Value);

        var vm = new RekaptulasiTahunanVM
        {
            DaftarTransaksi = daftarTransaksi,
            Tahun = rTahun.Value.Value,
            RAPBJ = rapbj
        };

        var html = await _razorTemplateEngine.RenderAsync("Areas/Dashboard/Views/Laporan/_LaporanRekaptulasiTahunanPartial.cshtml", vm);
        var htmlToPdf = new HtmlToPdfConverter();
        var pdfBinary = htmlToPdf.GeneratePdf(html);

        if (download)
            return File(pdfBinary, "application/pdf", $"Rekaptulasi Tahunan - {vm.Tahun}");

        return File(pdfBinary, "application/pdf");
    }

    public async Task<IActionResult> BKU(int bulan, int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        if(bulan <= 0 || bulan > 12) return BadRequest();

        var daftarTransaksi = (await _repositoriTransaksi.GetAllByTahun(tahun.Value)).Where(t => t.Tanggal.Month == bulan).ToList();

        return View(new BKUVM 
        { 
            Bulan = bulan, 
            DaftarTransaksi = daftarTransaksi,
            Tahun = tahun.Value
        });
    }

    [AllowAnonymous]
    public async Task<IActionResult> BKUPDF(int bulan, int? tahun = null, bool download = false)
    {
        tahun ??= DateTime.Now.Year;

        if (bulan <= 0 || bulan > 12) return BadRequest();

        var daftarTransaksi = (await _repositoriTransaksi.GetAllByTahun(tahun.Value)).Where(t => t.Tanggal.Month == bulan).ToList();

        var vm = new BKUVM
        {
            Bulan = bulan,
            DaftarTransaksi = daftarTransaksi,
            Tahun = tahun.Value
        };

        var html = await _razorTemplateEngine.RenderAsync("Areas/Dashboard/Views/Laporan/_LaporanBKUPartial.cshtml", vm);
        var htmlToPdf = new HtmlToPdfConverter();
        var pdfBinary = htmlToPdf.GeneratePdf(html);

        if (download)
            return File(pdfBinary, "application/pdf", $"Rekaptulasi Tahunan - {vm.Tahun}");

        return File(pdfBinary, "application/pdf");
    }
}