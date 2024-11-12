using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.DeleteAllByTahun;

internal class DeleteAllByTahunCommandHandler : ICommandHandler<DeleteAllByTahunCommand>
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteAllByTahunCommandHandler(
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriAkun repositoriAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriAkun = repositoriAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(DeleteAllByTahunCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        if (!await _repositoriAkun.IsExistOnTahun(tahun.Value))
            return new Error("DeleteAllByTahunCommandHandler.NoAkunOnTahun", $"Tidak Akun pada tahun : {tahun.Value.Value}");

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(tahun.Value);
        foreach (var jenisAkun in daftarJenisAkun)
            _repositoriJenisAkun.Delete(jenisAkun);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
