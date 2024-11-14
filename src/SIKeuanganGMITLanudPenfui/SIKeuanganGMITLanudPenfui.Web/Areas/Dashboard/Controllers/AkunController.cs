using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkunOnTahunFromTahun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateGolonganAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateJenisAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateKelompokAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditGolonganAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditJenisAkun;
using SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditKelompokAkun;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Controllers;

[Area("Dashboard")]
[Authorize(Roles = UserRoles.Bendahara)]
public class AkunController : Controller
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISender _sender;
    private readonly JsonSerializerOptions serializerSettings = new(){ ReferenceHandler = ReferenceHandler.IgnoreCycles };

    public AkunController(
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        ISender sender,
        IUnitOfWork unitOfWork)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _sender = sender;
        _unitOfWork = unitOfWork;
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
            DaftarGolonganAkun = daftarGolonganAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            IsAkunExist = await _repositoriAkun.IsExistOnTahun(rTahun.Value)
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
            DaftarGolonganAkun = daftarGolonganAkun.Where(a => a.Tahun == rTahun.Value).ToList(),
            IsAkunExist = await _repositoriAkun.IsExistOnTahun(rTahun.Value)
        });
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public IActionResult TambahJenisAkun(Jenis jenis, int tahun)
    {
        if (Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(
            new TambahJenisAkunVM
            {
                Tahun = tahun,
                Jenis = Jenis.Penerimaan,
                ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", values: new { Area = "Dashboard", tahun })!
            }
        );
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
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

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahKelompokAkun(Jenis jenis, int tahun)
    {
        if (Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(new TambahKelompokAkunVM
        {
            Jenis = jenis,
            Tahun = tahun,
            ReturnURL = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { Area = "Dashboard", tahun, jenis })!,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList()
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahKelompokAkun([FromForm] TambahKelompokAkunVM vm, [FromRoute] Jenis jenis, [FromRoute] int tahun)
    {
        if (vm.Tahun != tahun || vm.Jenis != jenis)
            return BadRequest();

        var command = new CreateKelompokAkunCommand(vm.Uraian, vm.Tahun, vm.IdJenisAkun);
        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code = {result.Error.Code}, Message = {result.Error.Message}");
            vm.DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList();
            return View(vm);
        }

        return Redirect(vm.ReturnURL);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahGolonganAkun(Jenis jenis, int tahun)
    {
        if(Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(new TambahGolonganAkunVM
        {
            Jenis = jenis,
            Tahun = tahun,
            ReturnURL = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { Area = "Dashboard", tahun})!,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList()
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahGolonganAkun([FromForm]TambahGolonganAkunVM vm, [FromRoute]Jenis jenis, [FromRoute] int tahun)
    {
        if (vm.Tahun != tahun || vm.Jenis != jenis)
            return BadRequest();

        var command = new CreateGolonganAkunCommand(vm.Uraian, vm.Tahun, vm.IdKelompokAkun);
        var result = await _sender.Send(command);
        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code = {result.Error.Code}, Message = {result.Error.Message}");
            vm.DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList();
            return View(vm);
        }

        return Redirect(vm.ReturnURL);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahAkun(Jenis jenis, int tahun)
    {
        if (Tahun.Create(tahun).IsFailure)
            return BadRequest();

        return View(new TambahAkunVM
        {
            Jenis = jenis,
            Tahun = tahun,
            ReturnURL = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { Area = "Dashboard", tahun })!,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList()
        });
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> TambahAkun([FromForm] TambahAkunVM vm, [FromRoute] Jenis jenis, [FromRoute] int tahun)
    {
        if (vm.Tahun != tahun || vm.Jenis != jenis)
            return BadRequest();

        if(jenis == Jenis.Penerimaan && vm.PresentaseSetoranSinode is null)
        {
            ModelState.AddModelError(nameof(TambahAkunVM.PresentaseSetoranSinode), "Untuk akun Penerimaan, presentase setoran sinode harus diisi");
            vm.DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList();
            return View(vm);
        }

        var command = new CreateAkunCommand(vm.Uraian, vm.Tahun, vm.PresentaseSetoranSinode / 100d, vm.IdJenisAkun, vm.IdKelompokAkun, vm.IdGolonganAkun);
        var result = await _sender.Send(command);
        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code = {result.Error.Code}, Message = {result.Error.Message}");
            vm.DaftarJenisAkun = (await _repositoriJenisAkun.GetAll()).Where(j => j.Tahun.Value == tahun && j.Jenis == jenis).ToList();
            return View(vm);
        }

        return Redirect(vm.ReturnURL);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditJenisAkun(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var jenisAkun = await _repositoriJenisAkun.Get(id);
        if (jenisAkun is null) return NotFound();

        if (jenisAkun.Jenis != jenis || jenisAkun.Tahun != rTahun.Value)
            return BadRequest();

        var vm = new EditJenisAkunVM
        {
            Id = id,
            Jenis = jenis,
            Tahun = tahun,
            Uraian = jenisAkun.Uraian,
            ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area="Dashboard"})!
        };

        return View(vm);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditJenisAkun(Jenis jenis, int tahun, int id, EditJenisAkunVM vm)
    {
        if (vm.Jenis != jenis || vm.Tahun != tahun || id != vm.Id) return BadRequest();

        var command = new EditJenisAkunCommand(vm.Id, vm.Uraian);
        var result = await _sender.Send(command);

        if(result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code : {result.Error.Code} Message : {result.Error.Message}");
            return View(vm);
        }

        return Redirect(vm.ReturnUrl);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditKelompokAkun(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var kelompokAkun = await _repositoriKelompokAkun.Get(id);
        if (kelompokAkun is null) return NotFound();

        if (kelompokAkun.JenisAkun.Jenis != jenis || kelompokAkun.Tahun != rTahun.Value)
            return BadRequest();

        var vm = new EditKelompokAkunVM
        {
            Id = id,
            Jenis = jenis,
            Tahun = tahun,
            Uraian = kelompokAkun.Uraian,
            IdJenisAkun = kelompokAkun.JenisAkun.Id,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == jenis).ToList(),
            ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!
        };

        return View(vm);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditKelompokAkun(Jenis jenis, int tahun, int id, EditKelompokAkunVM vm)
    {
        if (vm.Jenis != jenis || vm.Tahun != tahun || id != vm.Id) return BadRequest();

        var command = new EditKelompokAkunCommand(vm.Id, vm.Uraian, vm.IdJenisAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code : {result.Error.Code} Message : {result.Error.Message}");
            return View(vm);
        }

        return Redirect(vm.ReturnUrl);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditGolonganAkun(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var golonganAkun = await _repositoriGolonganAkun.Get(id);
        if (golonganAkun is null) return NotFound();

        if (golonganAkun.KelompokAkun.JenisAkun.Jenis != jenis || golonganAkun.Tahun != rTahun.Value)
            return BadRequest();

        var vm = new EditGolonganAkunVM
        {
            Id = id,
            Jenis = jenis,
            Tahun = tahun,
            Uraian = golonganAkun.Uraian,
            IdKelompokAkun = golonganAkun.KelompokAkun.Id,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == jenis).ToList(),
            ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!
        };

        return View(vm);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditGolonganAkun(Jenis jenis, int tahun, int id, EditGolonganAkunVM vm)
    {
        if (vm.Jenis != jenis || vm.Tahun != tahun || id != vm.Id) return BadRequest();

        var command = new EditGolonganAkunCommand(vm.Id, vm.Uraian, vm.IdKelompokAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code : {result.Error.Code} Message : {result.Error.Message}");
            return View(vm);
        }

        return Redirect(vm.ReturnUrl);
    }

    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditAkun(Jenis jenis, int tahun, int id)
    {
        var rTahun = Tahun.Create(tahun);
        if (rTahun.IsFailure) return BadRequest();

        var akun = await _repositoriAkun.Get(id);
        if (akun is null) return NotFound();

        if (akun.JenisAkun.Jenis != jenis || akun.Tahun != rTahun.Value)
            return BadRequest();

        var vm = new EditAkunVM
        {
            Id = id,
            Jenis = jenis,
            Tahun = tahun,
            Uraian = akun.Uraian,
            PresentaseSetoranSinode = (int?)(akun.PresentaseSetoran * 100),
            IdJenisAkun = akun.JenisAkun.Id,
            IdKelompokAkun = akun.KelompokAkun?.Id,
            IdGolonganAkun = akun.GolonganAkun?.Id,
            DaftarJenisAkun = (await _repositoriJenisAkun.GetAllByTahun(rTahun.Value)).Where(j => j.Jenis == jenis).ToList(),
            ReturnUrl = Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!
        };

        return View(vm);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> EditAkun(Jenis jenis, int tahun, int id, EditAkunVM vm)
    {
        if (vm.Jenis != jenis || vm.Tahun != tahun || id != vm.Id) return BadRequest();

        var command = new EditAkunCommand(vm.Id, vm.Uraian, vm.PresentaseSetoranSinode / 100d, vm.IdJenisAkun, vm.IdKelompokAkun, vm.IdGolonganAkun);
        var result = await _sender.Send(command);

        if (result.IsFailure)
        {
            ModelState.AddModelError(string.Empty, $"Error telah terjadi. Code : {result.Error.Code} Message : {result.Error.Message}");
            return View(vm);
        }

        return Redirect(vm.ReturnUrl);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusJenisAkun(Jenis jenis, int tahun, int id)
    {
        var jenisAkun = await _repositoriJenisAkun.Get(id);
        if (jenisAkun is null) return NotFound();

        if(jenisAkun.Jenis != jenis || jenisAkun.Tahun.Value != tahun)
            return BadRequest();

        _repositoriJenisAkun.Delete(jenisAkun);
        var result = await _unitOfWork.SaveChangesAsync();
        if(result.IsFailure)
        {
            return BadRequest();
        }

        return Redirect(Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusKelompokAkun(Jenis jenis, int tahun, int id)
    {
        var kelompokAkun = await _repositoriKelompokAkun.Get(id);
        if (kelompokAkun is null) return NotFound();

        if (kelompokAkun.JenisAkun.Jenis != jenis || kelompokAkun.Tahun.Value != tahun)
            return BadRequest();

        _repositoriKelompokAkun.Delete(kelompokAkun);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
        {
            return BadRequest();
        }

        return Redirect(Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusGolonganAkun(Jenis jenis, int tahun, int id)
    {
        var golonganAkun = await _repositoriGolonganAkun.Get(id);
        if (golonganAkun is null) return NotFound();

        if (golonganAkun.KelompokAkun.JenisAkun.Jenis != jenis || golonganAkun.Tahun.Value != tahun)
            return BadRequest();

        _repositoriGolonganAkun.Delete(golonganAkun);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
        {
            return BadRequest();
        }

        return Redirect(Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]/{id:int}")]
    public async Task<IActionResult> HapusAkun(Jenis jenis, int tahun, int id)
    {
        var akun = await _repositoriAkun.Get(id);
        if (akun is null) return NotFound();

        if (akun.JenisAkun.Jenis != jenis || akun.Tahun.Value != tahun)
            return BadRequest();

        _repositoriAkun.Delete(akun);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result.IsFailure)
        {
            return BadRequest();
        }

        return Redirect(Url.Action(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" })!);
    }

    [HttpPost]
    [Route("[area]/[controller]/{jenis}/{tahun:int}/[action]")]
    public async Task<IActionResult> ImportAkun(int tahun, Jenis jenis, int tahunSumber)
    {
        var command = new CreateAkunOnTahunFromTahunCommand(tahunSumber, tahun);
        var result = await _sender.Send(command);
        if(result.IsFailure)
            return BadRequest();

        return RedirectToAction(jenis == Jenis.Penerimaan ? nameof(Penerimaan) : nameof(Belanja), "Akun", new { tahun, Area = "Dashboard" });
    }

    public async Task<IActionResult> KelompokAkun(int idJenisAkun)
    {
        var jenisAkun = await _repositoriJenisAkun.Get(idJenisAkun);
        if(jenisAkun is null)
            return StatusCode(StatusCodes.Status400BadRequest);

        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllByJenis(jenisAkun);

        return Json(daftarKelompokAkun, serializerSettings);
    }

    public async Task<IActionResult> GolonganAkun(int idKelompokAkun)
    {
        var kelompokAkun = await _repositoriKelompokAkun.Get(idKelompokAkun);
        if (kelompokAkun is null)
            return StatusCode(StatusCodes.Status400BadRequest);

        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllByKelompokAkun(kelompokAkun);

        return Json(daftarGolonganAkun, serializerSettings);
    }
}
