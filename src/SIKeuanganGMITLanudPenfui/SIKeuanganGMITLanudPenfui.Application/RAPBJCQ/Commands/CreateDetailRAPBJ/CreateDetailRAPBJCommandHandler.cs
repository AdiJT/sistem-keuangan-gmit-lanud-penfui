using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateDetailRAPBJ;

internal class CreateDetailRAPBJCommandHandler : ICommandHandler<CreateDetailRAPBJCommand>
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public CreateDetailRAPBJCommandHandler(
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

    public async Task<Result> Handle(CreateDetailRAPBJCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);
        if (rapbj is null) return new Error("CreateDetailRAPBJCommandHandler.RAPBJNotFound", $"Tidak ada RAPBJ di tahun {request.Tahun}");

        var akun = await _repositoriAkun.Get(request.IdAkun);
        if (akun is null) return new Error("CreateDetailRAPBJCommandHandler.AkunNotFound", $"Tidak ada akun dengan Id : {request.IdAkun}");

        if (akun.Tahun != tahun.Value)
            return new Error(
                "CreateDetailRAPBJCommandHandler.AkunTahunDifferent",
                $"Akun tahun {akun.Tahun.Value} tidak dapat digunakan untuk RAPBJ tahun {tahun.Value}");


        if(rapbj.DaftarDetailRAPBJ.Any(d => d.Akun == akun))
            return new Error(
                "CreateDetailRAPBJCommandHandler.DetailRAPBJAlreadyExists",
                $"RAPBJ tahun {request.Tahun} sudah memiliki detail dengan IdAkun {request.IdAkun}");

        if (request.Volume <= 0)
            return new Error(
                "CreateDetailRAPBJCommandHandler.VolumeZeroOrNegative",
                "Volume tidak boleh nol atau negatif");

        if (request.HargaSatuan <= 0)
            return new Error(
                "CreateDetailRAPBJCommandHandler.HargaSatuanZeroOrNegative",
                "Harga Satuan tidak boleh nol atau negatif");

        if (string.IsNullOrWhiteSpace(request.Satuan))
            return new Error(
                "CreateDetailRAPBJCommandHandler.SatuanEmpty",
                "Satuan kosong atau hanya terdiri dari spasi");

        var detailRAPBJ = new DetailRAPBJ
        {
            TahunRAPBJ = tahun.Value,
            KodeAkun = akun.Id,
            Volume = request.Volume,
            Satuan = request.Satuan,
            HargaSatuan = request.HargaSatuan,
            RAPBJ = rapbj,
            Akun = akun
        };

        rapbj.DaftarDetailRAPBJ.Add(detailRAPBJ);
        _repositoriDetailRAPBJ.Add(detailRAPBJ);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
