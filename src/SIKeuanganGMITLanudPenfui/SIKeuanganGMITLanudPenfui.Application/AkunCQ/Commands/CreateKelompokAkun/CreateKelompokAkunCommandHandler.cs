using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateKelompokAkun;

internal class CreateKelompokAkunCommandHandler : ICommandHandler<CreateKelompokAkunCommand>
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateKelompokAkunCommandHandler(
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateKelompokAkunCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var jenisAkun = await _repositoriJenisAkun.Get(request.IdJenisAkun);
        if (jenisAkun is null)
            return new Error("CreateKelompokAkunCommand.JenisAkunNotFound", $"Jenis Akun dengan Id : {request.IdJenisAkun} tidak ditemukan");

        var kelompokAkun = KelompokAkun.Create(request.Uraian, tahun.Value, jenisAkun);
        if (kelompokAkun.IsFailure) return kelompokAkun.Error;

        _repositoriKelompokAkun.Add(kelompokAkun.Value);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
