using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.TransaksiModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class TransaksiController : Controller
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IFileUploadService _fileUploadService;

    public TransaksiController(
        IRepositoriTransaksi repositoriTransaksi,
        IFileUploadService fileUploadService)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _fileUploadService = fileUploadService;
    }

    [Route("/[area]/[controller]/{jenis}/{tahun:int?}")]
    public async Task<IActionResult> Index(Jenis jenis, int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var daftarTransaksi = await _repositoriTransaksi.GetAllByTahun(tahun.Value, jenis);

        return View(new IndexVM
        {
            Tahun = tahun.Value,
            Jenis = jenis,
            DaftarTransaksi = daftarTransaksi.OrderBy(p => p.Tanggal).ToList()
        });
    }
}
