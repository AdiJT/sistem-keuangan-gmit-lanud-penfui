using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteDetailRAPBJ;

internal class DeleteDetailRAPBJCommandHandler : ICommandHandler<DeleteDetailRAPBJCommand>
{
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteDetailRAPBJCommandHandler(
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ,
        IRepositoriRAPBJ repositoriRAPBJ,
        IUnitOfWork unitOfWork)
    {
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
        _repositoriRAPBJ = repositoriRAPBJ;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(DeleteDetailRAPBJCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);
        if (rapbj is null) return new Error("EditDetailRAPBJCommandHandler.RAPBJNotFound", $"Tidak ada RAPBJ di tahun {request.Tahun}");

        var detailRAPBJ = rapbj.DaftarDetailRAPBJ.FirstOrDefault(d => d.KodeAkun == request.IdAkun);
        if (detailRAPBJ is null)
            return new Error(
                "EditDetailRAPBJCommandHandler.DetailRAPBJNotFound",
                $"Detail RAPBJ dengan di tahun {request.Tahun} dengan Id Akun {request.IdAkun} tidak ditemukan");

        rapbj.DaftarDetailRAPBJ.Remove(detailRAPBJ);
        _repositoriDetailRAPBJ.Delete(detailRAPBJ);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
