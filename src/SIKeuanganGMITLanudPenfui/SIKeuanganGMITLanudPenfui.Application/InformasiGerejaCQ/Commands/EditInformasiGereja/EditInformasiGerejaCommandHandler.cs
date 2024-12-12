using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.EditInformasiGereja;

internal class EditInformasiGerejaCommandHandler : ICommandHandler<EditInformasiGerejaCommand>
{
    private readonly IRepositoriInformasiGereja _repositoriInformasiGereja;
    private readonly IUnitOfWork _unitOfWork;

    public EditInformasiGerejaCommandHandler(IRepositoriInformasiGereja repositoriInformasiGereja, IUnitOfWork unitOfWork)
    {
        _repositoriInformasiGereja = repositoriInformasiGereja;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditInformasiGerejaCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var informasiGereja = await _repositoriInformasiGereja.Get(tahun.Value);
        if (informasiGereja is null) 
            return new Error("EditInformasiGerejaCommandHandler.InformasiGerejaTidakDitemukan", $"Tidak ada informasi di tahun {request.Tahun}");

        informasiGereja.KetuaMajelisJemaat = request.KetuaMajelisJemaat;
        informasiGereja.Bendahara = request.Bendahara;

        _repositoriInformasiGereja.Update(informasiGereja);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}
