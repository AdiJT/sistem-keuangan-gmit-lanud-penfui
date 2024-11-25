using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateRAPBJ;

internal class CreateRAPBJCommandHandler : ICommandHandler<CreateRAPBJCommand>
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public CreateRAPBJCommandHandler(
        IRepositoriRAPBJ repositoriRAPBJ,
        IUnitOfWork unitOfWork,
        IRepositoriAkun repositoriAkun,
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _unitOfWork = unitOfWork;
        _repositoriAkun = repositoriAkun;
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
    }

    public async Task<Result> Handle(CreateRAPBJCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var daftarAkun = await _repositoriAkun.GetAllByTahun(tahun.Value);

        if (await _repositoriRAPBJ.IsExist(tahun.Value))
            return new Error("CreateRAPBJCommandHandler.RAPBJAlreadyExist", $"Sudah ada RAPBJ di tahun {request.Tahun}");

        var rapbj = new RAPBJ
        {
            Tahun = tahun.Value
        };

        _repositoriRAPBJ.Add(rapbj);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}