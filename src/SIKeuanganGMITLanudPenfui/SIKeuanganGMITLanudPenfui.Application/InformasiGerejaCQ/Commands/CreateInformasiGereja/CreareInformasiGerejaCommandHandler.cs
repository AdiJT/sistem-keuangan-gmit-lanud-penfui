using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.CreateInformasiGereja;

internal class CreareInformasiGerejaCommandHandler : ICommandHandler<CreareInformasiGerejaCommand>
{
    private readonly IRepositoriInformasiGereja _repositoriInformasiGereja;
    private readonly IUnitOfWork _unitOfWork;

    public CreareInformasiGerejaCommandHandler(
        IRepositoriInformasiGereja repositoriInformasiGereja,
        IUnitOfWork unitOfWork)
    {
        _repositoriInformasiGereja = repositoriInformasiGereja;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreareInformasiGerejaCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        if (await _repositoriInformasiGereja.IsDuplicate(tahun.Value))
            return new Error("CreareInformasiGerejaCommand.TahunDuplikat", $"Sudah ada informasi gereja untuk tahun {request.Tahun}");

        var informasiGereja = new InformasiGereja
        {
            Tahun = tahun.Value,
            KetuaMajelisJemaat = request.KetuaMajelisJemaat,
            Bendahara = request.Bendahara
        };
        _repositoriInformasiGereja.Add(informasiGereja);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}
