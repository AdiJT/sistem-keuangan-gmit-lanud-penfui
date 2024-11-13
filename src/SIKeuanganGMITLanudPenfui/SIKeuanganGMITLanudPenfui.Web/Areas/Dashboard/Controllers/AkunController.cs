using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateJenisAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateKelompokAkun;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class AkunController : Controller
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly ISender _sender;

    public AkunController(
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        ISender sender)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _sender = sender;
    }

    [Route("[area]/[controller]/[action]/{tahun:int?}")]
    public async Task<IActionResult> Penerimaan(int? tahun)
    {
        tahun ??= DateTime.Now.Year;
        var rTahun = Tahun.Create(tahun.Value);

        if (rTahun.IsFailure)
            return BadRequest();

        var daftarAkun = await _repositoriAkun.GetAllPenerimaan();
        var daftarJenisAkun = await _repositoriJenisAkun.GetAllPenerimaan();
        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllPenerimaan();
        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllPenerimaan();

        return View(new PenerimaanVM
        {
            Tahun = tahun.Value,
            DaftarAkun = daftarAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarJenisAkun = daftarJenisAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarKelompokAkun = daftarKelompokAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarGolonganAkun = daftarGolonganAkun.Where(a => a.Tahun == rTahun.Value).ToList()
        });
    }
     
    [Route("[area]/[controller]/[action]/{tahun:int?}")]
    public async Task<IActionResult> Belanja(int? tahun)
    {
        tahun ??= DateTime.Now.Year;
        var rTahun = Tahun.Create(tahun.Value);

        if (rTahun.IsFailure)
            return BadRequest();

        var daftarAkun = await _repositoriAkun.GetAllBelanja();
        var daftarJenisAkun = await _repositoriJenisAkun.GetAllBelanja();
        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllBelanja();
        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllBelanja();

        return View(new BelanjaVM
        {
            Tahun = tahun.Value,
            DaftarAkun = daftarAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarJenisAkun = daftarJenisAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarKelompokAkun = daftarKelompokAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            DaftarGolonganAkun = daftarGolonganAkun.Where(a => a.Tahun == rTahun.Value).ToList() 
        });
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/TambahJenisAkun")]
    public IActionResult TambahJenisAkun(Jenis jenis, int tahun)
    {
        if (Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(
            new TambahJenisAkunVM
            {
                Tahun = tahun,
                Jenis = Jenis.Penerimaan,
                ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { Area = "Dashboard", tahun })!
            }
        );
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/TambahJenisAkun")]
    public async Task<IActionResult> TambahJenisAkun([FromForm]TambahJenisAkunVM tambahJenisAkunVM, [FromRoute]Jenis jenis, [FromRoute]int tahun)
    {
        if(tambahJenisAkunVM.Jenis != jenis || tambahJenisAkunVM.Tahun != tahun)
            return BadRequest();

        var createJenisAkunCommand = new CreateJenisAkunCommand(tambahJenisAkunVM.Uraian, tambahJenisAkunVM.Tahun, tambahJenisAkunVM.Jenis);
        var result = await _sender.Send(createJenisAkunCommand);

        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code = {result.Error.Code}, Message = {result.Error.Message}");
            return View(tambahJenisAkunVM);
        }

        return Redirect(tambahJenisAkunVM.ReturnUrl);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/TambahKelompokAkun")]
    public IActionResult TambahKelompokAkun(Jenis jenis, int tahun)
    {
        if (Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(new TambahKelompokAkunVM(_repositoriJenisAkun)
        {
            Jenis = jenis,
            Tahun = tahun,
            ReturnURL = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { Area = "Dashboard", tahun, jenis})!
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/TambahKelompokAkun")]
    public async Task<IActionResult> TambahKelompokAkun([FromForm] TambahKelompokAkunVM vm, [FromRoute] Jenis jenis, [FromRoute] int tahun)
    {
        if (vm.Tahun != tahun || vm.Jenis != jenis)
            return BadRequest();

        var command = new CreateKelompokAkunCommand(vm.Uraian, vm.Tahun, vm.IdJenisAkun);
        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code = {result.Error.Code}, Message = {result.Error.Message}");
            return View(vm);
        }

        return Redirect(vm.ReturnURL);
    }
}
