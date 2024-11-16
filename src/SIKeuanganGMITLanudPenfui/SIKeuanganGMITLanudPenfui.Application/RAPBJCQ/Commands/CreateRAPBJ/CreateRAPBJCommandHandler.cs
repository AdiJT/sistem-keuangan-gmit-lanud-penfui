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

        if (!await _repositoriAkun.IsExistOnTahun(tahun.Value))
            return new Error("CreateRAPBJCommandHandler.NoAkunExist", $"Tidak ada Akun di tahun {request.Tahun}");

        var daftarAkun = await _repositoriAkun.GetAllByTahun(tahun.Value);

        if (await _repositoriRAPBJ.IsExist(tahun.Value))
            return new Error("CreateRAPBJCommandHandler.RAPBJAlreadyExist", $"Sudah ada RAPBJ di tahun {request.Tahun}");

        var rapbj = new RAPBJ
        {
            Tahun = tahun.Value
        };

        foreach (var akun in daftarAkun)
        {
            var detailRAPBJ = new DetailRAPBJ
            {
                TahunRAPBJ = tahun.Value,
                KodeAkun = akun.Id,
                RAPBJ = rapbj,
                Akun = akun,
                HargaSatuan = 0,
                Satuan = "",
                Volume = 0
            };

            rapbj.DaftarDetailRAPBJ.Add(detailRAPBJ);
            _repositoriDetailRAPBJ.Add(detailRAPBJ);   
        }    

        _repositoriRAPBJ.Add(rapbj);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure) return result.Error;

        return Result.Success();
    }
}