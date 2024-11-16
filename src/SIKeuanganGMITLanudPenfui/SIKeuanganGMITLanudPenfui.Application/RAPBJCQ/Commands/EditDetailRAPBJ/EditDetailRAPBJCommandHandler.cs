using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.EditDetailRAPBJ;

internal class EditDetailRAPBJCommandHandler : ICommandHandler<EditDetailRAPBJCommand>
{
    private readonly IRepositoriRAPBJ _repositoriRAPBJ;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriDetailRAPBJ _repositoriDetailRAPBJ;
    private readonly IUnitOfWork _unitOfWork;

    public EditDetailRAPBJCommandHandler(
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

    public async Task<Result> Handle(EditDetailRAPBJCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        var rapbj = await _repositoriRAPBJ.Get(tahun.Value);
        if (rapbj is null) return new Error("EditDetailRAPBJCommandHandler.RAPBJNotFound", $"Tidak ada RAPBJ di tahun {request.Tahun}");

        var akun = await _repositoriAkun.Get(request.IdAkun);
        if (akun is null) return new Error("EditDetailRAPBJCommandHandler.AkunNotFound", $"Tidak ada akun dengan Id : {request.IdAkun}");

        if (akun.Tahun != tahun.Value)
            return new Error(
                "EditDetailRAPBJCommandHandler.AkunTahunDifferent",
                $"Akun tahun {akun.Tahun.Value} tidak dapat digunakan untuk RAPBJ tahun {tahun.Value}");

        if (request.Volume <= 0)
            return new Error(
                "EditDetailRAPBJCommandHandler.VolumeZeroOrNegative",
                "Volume tidak boleh nol atau negatif");

        if (request.HargaSatuan <= 0)
            return new Error(
                "EditDetailRAPBJCommandHandler.HargaSatuanZeroOrNegative",
                "Harga Satuan tidak boleh nol atau negatif");

        if (string.IsNullOrWhiteSpace(request.Satuan))
            return new Error(
                "EditDetailRAPBJCommandHandler.SatuanEmpty",
                "Satuan kosong atau hanya terdiri dari spasi");

        var detailRAPBJ = rapbj.DaftarDetailRAPBJ.FirstOrDefault(d => d.KodeAkun == akun.Id);
        if(detailRAPBJ is null)
            return new Error(
                "EditDetailRAPBJCommandHandler.DetailRAPBJNotFound",
                $"Detail RAPBJ dengan di tahun {request.Tahun} dengan Id Akun {request.IdAkun} tidak ditemukan");

        detailRAPBJ.Volume = request.Volume;
        detailRAPBJ.Satuan = request.Satuan;
        detailRAPBJ.HargaSatuan = request.HargaSatuan;
        
        _repositoriDetailRAPBJ.Update(detailRAPBJ);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
