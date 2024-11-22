using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.AddAllAkun;

internal class AddAllAkunCommandHandler : ICommandHandler<AddAllAkunCommand>
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public AddAllAkunCommandHandler(
        IRepositoriRAPBJ repositoriRAPBJ,
        IRepositoriAkun repositoriAkun,
        IRepositoriDetailRAPBJ repositoriDetailRAPBJ,
        IUnitOfWork unitOfWork)
    {
        _repositoriRAPBJ = repositoriRAPBJ;
        _repositoriAkun = repositoriAkun;
        _repositoriDetailRAPBJ = repositoriDetailRAPBJ;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(AddAllAkunCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);
        if (rapbj is null) return new Error("AddAllAkunCommandHandler.RAPBJNotFound", $"Tidak ada RAPBJ di Tahun {request.Tahun}");

        if (!await _repositoriAkun.IsExistOnTahun(tahun.Value))
            return new Error("AddAllAkunCommandHandler.NoAkunFound", $"Tidak ada akun di Tahun {request.Tahun}");

        var daftarAkun = await _repositoriAkun.GetAllByTahun(tahun.Value);
        foreach (var akun in daftarAkun)
        {
            var detailRAPBJ = new DetailRAPBJ
            {
                Akun = akun,
                RAPBJ = rapbj,
                TahunRAPBJ = rapbj.Tahun,
                KodeAkun = akun.Id,
                Satuan = "Tidak Ada",
                HargaSatuan = 0,
                Volume = 0
            };

            if (!rapbj.DaftarDetailRAPBJ.Contains(detailRAPBJ))
            {
                rapbj.DaftarDetailRAPBJ.Add(detailRAPBJ);
                _repositoriDetailRAPBJ.Add(detailRAPBJ);
            }
        }

        _repositoriRAPBJ.Update(rapbj);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
