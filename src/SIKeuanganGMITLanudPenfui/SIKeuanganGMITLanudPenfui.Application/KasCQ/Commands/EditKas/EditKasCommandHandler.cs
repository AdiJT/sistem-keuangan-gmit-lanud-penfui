using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.EditKas;

internal class EditKasCommandHandler : ICommandHandler<EditKasCommand>
{
    private readonly IRepositoriKas _repositoriKas;
    private readonly IUnitOfWork _unitOfWork;

    public EditKasCommandHandler(IRepositoriKas repositoriKas, IUnitOfWork unitOfWork)
    {
        _repositoriKas = repositoriKas;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditKasCommand request, CancellationToken cancellationToken)
    {
        var kas = await _repositoriKas.Get(request.IdKas);
        if (kas is null) return new Error("EditKasCommandHandler.KasTidakDitemukan", $"Kas dengan Id {request.IdKas} tidak ditemukan");

        if((await _repositoriKas.GetAll()).Any(k => k.Id != kas.Id && k.Uraian == request.Uraian))
            return new Error("EditKasCommandHandler.UraianTidakUnik", $"Sudah ada Kas dengan uraian {request.Uraian}");

        kas.Uraian = request.Uraian;
        kas.Keterangan = request.Keterangan;
        _repositoriKas.Update(kas);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
