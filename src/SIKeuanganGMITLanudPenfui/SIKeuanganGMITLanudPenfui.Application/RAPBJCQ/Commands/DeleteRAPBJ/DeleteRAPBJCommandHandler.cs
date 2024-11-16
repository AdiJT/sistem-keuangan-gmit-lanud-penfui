using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteRAPBJ;

internal class DeleteRAPBJCommandHandler : ICommandHandler<DeleteRAPBJCommand>
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteRAPBJCommandHandler(IRepositoriRAPBJ repositoriRAPBJ, IUnitOfWork unitOfWork)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _unitOfWork = unitOfWork;
    }


    public async Task<Result> Handle(DeleteRAPBJCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);
        if (rapbj is null)
            return new Error("DeleteRAPBJCommandHandler.RAPBJNotFound", $"Tidak ada RAPBJ di tahun {request.Tahun}");

        _repositoriRAPBJ.Delete(rapbj);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}
