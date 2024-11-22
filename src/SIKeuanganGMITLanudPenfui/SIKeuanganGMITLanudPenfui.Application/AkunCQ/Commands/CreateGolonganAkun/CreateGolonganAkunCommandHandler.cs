using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateGolonganAkun;

internal class CreateGolonganAkunCommandHandler : ICommandHandler<CreateGolonganAkunCommand>
{
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateGolonganAkunCommandHandler(
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateGolonganAkunCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var kelompokAkun = await _repositoriKelompokAkun.Get(request.IdKelompokAkun);
        if (kelompokAkun is null)
            return new Error("CreateGolonganAkunCommand.KelompokAkunNotFound", $"Kelompok Akun dengan Id : {request.IdKelompokAkun} tidak ditemukan");

        var golonganAkun = GolonganAkun.Create(request.Uraian, tahun.Value, request.Kode, kelompokAkun);
        if (golonganAkun.IsFailure) return golonganAkun.Error;

        _repositoriGolonganAkun.Add(golonganAkun.Value);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}
