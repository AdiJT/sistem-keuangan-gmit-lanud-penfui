using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.PenerimaanModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class PenerimaanController : Controller
{
    private readonly IRepositoriPenerimaan _repositoriPenerimaan;
    private readonly IFileUploadService _fileUploadService;

    public PenerimaanController(
        IRepositoriPenerimaan repositoriPenerimaan,
        IFileUploadService fileUploadService)
    {
        _repositoriPenerimaan = repositoriPenerimaan;
        _fileUploadService = fileUploadService;
    }

    public async Task<IActionResult> Index(int? tahun = null)
    {
        tahun ??= DateTime.Now.Year;

        var daftarPenerimaan = await _repositoriPenerimaan.GetAllByTahun(tahun.Value);

        return View(new IndexVM
        {
            Tahun = tahun.Value,
            DaftarPenerimaan = daftarPenerimaan.OrderBy(p => p.Tanggal).ToList()
        });
    }
}
