using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.CreateKas;

internal class CreateKasCommandHandler : ICommandHandler<CreateKasCommand>
{
    private readonly IRepositoriKas _repositoriKas;
    private readonly IUnitOfWork _unitOfWork;

    public CreateKasCommandHandler(IRepositoriKas repositoriKas, IUnitOfWork unitOfWork)
    {
        _repositoriKas = repositoriKas;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateKasCommand request, CancellationToken cancellationToken)
    {
        if (request.Saldo < 0)
            return new Error("CreateKasCommandHandler.SaldoAwalNegatif", "Saldo awal kas tidak boleh negatif");

        if ((await _repositoriKas.GetAll()).Any(k => k.Uraian == request.Uraian))
            return new Error("CreateKasCommandHandler.UraianTidakUnik", $"Kas dengan uraian {request.Uraian} sudah ada");

        var kas = new Kas
        {
            Uraian = request.Uraian,
            Saldo = request.Saldo,
            Keterangan = request.Keterangan
        };

        _repositoriKas.Add(kas);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
