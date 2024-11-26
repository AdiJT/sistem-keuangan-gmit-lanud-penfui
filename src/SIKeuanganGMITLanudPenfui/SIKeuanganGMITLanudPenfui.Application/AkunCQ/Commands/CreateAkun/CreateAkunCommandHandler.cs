using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkun;

internal class CreateAkunCommandHandler : ICommandHandler<CreateAkunCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateAkunCommandHandler(
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

    public async Task<Result> Handle(CreateAkunCommand request, CancellationToken cancellationToken)
    {
        var jenisAkun = await _repositoriJenisAkun.Get(request.IdJenisAkun);

        if (jenisAkun is null)
            return new Error("CreateAkunCommandHandler.JenisAkunNotFound",
                $"Jenis Akun dengan Id {request.IdJenisAkun} tidak ditemukan");

        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure)
            return tahun.Error;

        var akun = await CreateAkunAsync(request, tahun.Value, jenisAkun, request.Kode);
        if (akun.IsFailure)
            return akun.Error;

        _repositoriAkun.Add(akun.Value);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }

    private async Task<Result<Akun>> CreateAkunAsync(CreateAkunCommand request, Tahun tahun, JenisAkun jenisAkun, int kode)
    {
        if (request is { IdKelompokAkun: null, IdGolonganAkun: null })
        {
            return Akun.CreateWithJenisAkun(
                request.Uraian,
                tahun,
                request.SetoranSinode,
                kode,
                jenisAkun);
        }
        else if (request is { IdKelompokAkun: not null, IdGolonganAkun: null })
        {
            var kelompokAkun = await _repositoriKelompokAkun.Get(request.IdKelompokAkun.Value);
            if (kelompokAkun is null)
                return new Error("CreataAkunCommandHandler.KelompokAkunNotFound",
                    $"Kelompok Akun dengan Id {request.IdKelompokAkun} tidak ditemukan");

            return Akun.CreateWithKelompokAkun(
                request.Uraian,
                tahun,
                request.SetoranSinode,
                kode,
                kelompokAkun);
        }
        else if (request is { IdKelompokAkun: null, IdGolonganAkun: not null })
        {
            var golonganAkun = await _repositoriGolonganAkun.Get(request.IdGolonganAkun.Value);
            if (golonganAkun is null)
                return new Error("CreataAkunCommandHandler.GolonganAkunNotFound",
                    $"Golongan Akun dengan Id {request.IdGolonganAkun} tidak ditemukan");

            return Akun.CreateWithGolonganAkun(
                request.Uraian,
                tahun,
                request.SetoranSinode,
                kode,
                golonganAkun);
        }
        else
        {
            var golonganAkun = await _repositoriGolonganAkun.Get(request.IdGolonganAkun!.Value);
            if (golonganAkun is null)
                return new Error("CreataAkunCommandHandler.GolonganAkunNotFound",
                    $"Golongan Akun dengan Id {request.IdGolonganAkun} tidak ditemukan");

            return Akun.CreateWithGolonganAkun(
                request.Uraian,
                tahun,
                request.SetoranSinode,
                kode,
                golonganAkun);
        }
    }
}
