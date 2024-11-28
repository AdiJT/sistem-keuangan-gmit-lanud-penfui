using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Dashboard.Models.LaporanModels;

namespace SIKeuanganGMITLanudPenfui.Web.Controllers;

public class LaporanController : Controller
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IRepositoriKas _repositoriKas;

    public LaporanController(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriTransaksi repositoriTransaksi,
        IRepositoriKas repositoriKas)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriTransaksi = repositoriTransaksi;
        _repositoriKas = repositoriKas;
    }

    public async Task<IActionResult> Index()
    {
        var daftarTransaksi = await _repositoriTransaksi.GetAll();

        var kas = await _repositoriKas.Get(1);

        return View(new IndexVM { DaftarTransaksi = daftarTransaksi, Kas = kas!});
    }

    public async Task<IActionResult> BKU(int? tahun = null, int bulan = 1)
    {
        tahun ??= DateTime.Now.Year;

        if (bulan <= 0 || bulan > 12) 
            bulan = 1;

        var daftarTransaksi = (await _repositoriTransaksi.GetAllByTahun(tahun.Value))
            .Where(t => t.Tanggal.Month == bulan)
            .OrderBy(t => t.Tanggal)
            .ToList();

        return View(new BKUVM
        {
            Bulan = bulan,
            Tahun = tahun.Value,
            DaftarTransaksi = daftarTransaksi
        });
    }

    public async Task<IActionResult> RekaptulasiTahunan(int? tahun = null)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);

        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        var daftarTransaksi = await _repositoriTransaksi.GetAllByTahun(rTahun.Value.Value);

        return View(new RekaptulasiTahunanVM
        {
            DaftarTransaksi = daftarTransaksi,
            RAPBJ = rapbj,
            Tahun = rTahun.Value.Value
        });
    }

    public async Task<IActionResult> RAPBJ(int? tahun = null)
    {
        var rTahun = Tahun.Create(tahun ?? DateTime.Now.Year);
        if (rTahun.IsFailure) return BadRequest();

        var rapbj = await _repositoriRAPBJ.Get(rTahun.Value);
        if (rapbj is null) return NotFound();

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(rTahun.Value);
        var daftarJenisAkunPenerimaan = daftarJenisAkun.Where(j => j.Jenis == Jenis.Penerimaan).OrderBy(j => j.Kode).ToList();
        var daftarJenisAkunBelanja = daftarJenisAkun.Where(j => j.Jenis == Jenis.Belanja).OrderBy(j => j.Kode).ToList();

        return View(new RAPBJVM
        {
            RAPBJ = rapbj,
            DaftarJenisAkunPenerimaan = daftarJenisAkunPenerimaan,
            DaftarJenisAkunBelanja = daftarJenisAkunBelanja,
            Tahun = rTahun.Value.Value
        });
    }
}