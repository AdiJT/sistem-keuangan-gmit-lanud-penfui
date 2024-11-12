using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditGolonganAkun;

internal class EditGolonganAkunCommandHandler : ICommandHandler<EditGolonganAkunCommand>
{
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IUnitOfWork _unitOfWork;

    public EditGolonganAkunCommandHandler(
        IRepositoriGolonganAkun repositoriGolonganAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditGolonganAkunCommand request, CancellationToken cancellationToken)
    {
        var golonganAkun = await _repositoriGolonganAkun.Get(request.IdGolonganAkun);
        if (golonganAkun is null)
            return new Error("EditGolonganAkunCommandHandler.GolonganAkunNotFound",
                $"Golongan Akun dengan Id : {request.IdGolonganAkun} tidak ditemukan");

        var kelompokAkun = await _repositoriKelompokAkun.Get(request.IdKelompokAkun);
        if(kelompokAkun is null)
            return new Error("EditGolonganAkunCommandHandler.KelompokAkunNotFound",
                $"Kelompok Akun dengan Id : {request.IdKelompokAkun} tidak ditemukan");

        if(kelompokAkun.Tahun != golonganAkun.Tahun)
            return new Error("EditGolonganAkunCommandHandler.TahunKelompokAkunDifferent",
                $"Tahun Kelompok Akun berbeda dengan tahun Golongan Akun");

        if(kelompokAkun.JenisAkun.Jenis != golonganAkun.KelompokAkun.JenisAkun.Jenis)
            return new Error("EditGolonganAkunCommandHandler.JenisKelompokAkunDifferent",
                $"Jenis Kelompok Akun berbeda dengan jenis Golongan Akun");

        golonganAkun.Uraian = request.Uraian;
        golonganAkun.KelompokAkun = kelompokAkun;

        _repositoriGolonganAkun.Update(golonganAkun);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
