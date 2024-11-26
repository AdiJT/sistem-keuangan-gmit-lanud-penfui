using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditAkun;

internal class EditAkunCommandHandler : ICommandHandler<EditAkunCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;

    public EditAkunCommandHandler(
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditAkunCommand request, CancellationToken cancellationToken)
    {
        var akun = await _repositoriAkun.Get(request.IdAkun);
        if (akun is null)
            return new Error("EditAkunCommandHandler.AkunNotFound", $"Akun dengan Id : {request.IdAkun} tidak ditemukan");

        var jenisAkun = await _repositoriJenisAkun.Get(request.IdJenisAkun);
        if (jenisAkun is null)
            return new Error("EditAkunCommandHandler.JenisAkunNotFound", $"Jenis Akun dengan Id : {request.IdJenisAkun} tidak ditemukan");

        if(jenisAkun.Tahun != akun.Tahun)
            return new Error("EditAkunCommandHandler.JenisAkunTahunDifferent", "Tahun Jenis Akun berbeda dengan tahun Akun");

        if (jenisAkun.Jenis != akun.JenisAkun.Jenis)
            return new Error("EditAkunCommandHandler.JenisJenisAkunDifferent", "Jenis dari Jenis Akun baru berbeda dengan yang lama");

        if (request.IdKelompokAkun is not null && request.IdGolonganAkun is null)
        {
            var kelompokAkun = await _repositoriKelompokAkun.Get(request.IdKelompokAkun.Value);
            if (kelompokAkun is null)
                return new Error("EditAkunCommandHandler.KelompokAkunNotFound", $"Kelompok Akun dengan Id : {request.IdKelompokAkun} tidak ditemukan");

            if (kelompokAkun.Tahun != akun.Tahun)
                return new Error("EditAkunCommandHandler.KelompokAkunTahunDifferent", "Tahun Kelompok Akun berbeda dengan tahun Akun");

            if (kelompokAkun.JenisAkun != jenisAkun)
                return new Error("EditAkunCommandHandler.KelompokAkunDifferentJenisAkun", "Jenis Akun dari Kelompok Akun berbeda dengan Jenis Akun");

            if (kelompokAkun.DaftarIAkun.Any(a => a.Kode == request.Kode))
                return new Error("EditAkunCommandHandler.KodeNotUnique", $"Kode Akun sudah ada di kelompok akun {kelompokAkun.Uraian}");

            akun.KelompokAkun = kelompokAkun;
            akun.GolonganAkun = null;
        }
        else if (request.IdGolonganAkun is not null && request.IdKelompokAkun is null)
        {
            var golonganAkun = await _repositoriGolonganAkun.Get(request.IdGolonganAkun.Value);
            if(golonganAkun is null)
                return new Error("EditAkunCommandHandler.GolonganAkunNotFound", $"Golongan Akun dengan Id : {request.IdGolonganAkun} tidak ditemukan");

            if(golonganAkun.Tahun != akun.Tahun)
                return new Error("EditAkunCommandHandler.GolonganAkunTahunDifferent", "Tahun Golongan Akun berbeda dengan tahun input");

            if(golonganAkun.KelompokAkun.JenisAkun != jenisAkun)
                return new Error("EditAkunCommandHandler.GolonganAkunDifferentJenisAkun", "Jenis Akun dari Golongan Akun berbeda dengan Jenis Akun");

            if (golonganAkun.DaftarAkun.Any(a => a.Kode == request.Kode))
                return new Error("EditAkunCommandHandler.KodeNotUnique", $"Kode Akun sudah ada di golongan akun {golonganAkun.Uraian}");

            akun.GolonganAkun = golonganAkun;
            akun.KelompokAkun = null;
        }
        else if(request.IdGolonganAkun is not null && request.IdKelompokAkun is not null)
        {
            var golonganAkun = await _repositoriGolonganAkun.Get(request.IdGolonganAkun.Value);
            if (golonganAkun is null)
                return new Error("EditAkunCommandHandler.GolonganAkunNotFound", $"Golongan Akun dengan Id : {request.IdGolonganAkun} tidak ditemukan");

            if (golonganAkun.Tahun != akun.Tahun)
                return new Error("EditAkunCommandHandler.GolonganAkunTahunDifferent", "Tahun Golongan Akun berbeda dengan tahun input");

            if (golonganAkun.KelompokAkun.JenisAkun != jenisAkun)
                return new Error("EditAkunCommandHandler.GolonganAkunDifferentJenisAkun", "Jenis Akun dari Golongan Akun berbeda dengan Jenis Akun");

            if (golonganAkun.DaftarAkun.Any(a => a.Kode == request.Kode))
                return new Error("EditAkunCommandHandler.KodeNotUnique", $"Kode Akun sudah ada di golongan akun {golonganAkun.Uraian}");

            akun.GolonganAkun = golonganAkun;
            akun.KelompokAkun = null;
        } 
        else
        {
            if(jenisAkun.DaftarIAkun.Any(a => a.Kode == request.Kode && !a.Equals(akun)))
                return new Error("EditAkunCommandHandler.KodeNotUnique", $"Kode Akun sudah ada di jenis akun {jenisAkun.Uraian}");

            akun.KelompokAkun = null;
            akun.GolonganAkun = null;
        }

        if (jenisAkun.Jenis == Jenis.Belanja && request.SetoranSinode is not null)
            return new Error("EditAkunCommandHandler.AkunBelanjaCantHavePresentaseSetoranSinode",
                "Akun jenis Belanja tidak dapat memiliki Presentase Setoran Sinode");

        akun.SetoranSinode = request.SetoranSinode;
        akun.JenisAkun = jenisAkun;
        akun.Uraian = request.Uraian;
        akun.Kode = request.Kode;

        _repositoriAkun.Update(akun);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
