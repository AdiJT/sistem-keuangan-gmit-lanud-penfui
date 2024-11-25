using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.PenerimaanCQ.Commands.CreatePenerimaan;

internal class CreatePenerimaanCommandHandler : ICommandHandler<CreatePenerimaanCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriPenerimaan _repositoriPenerimaan;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public CreatePenerimaanCommandHandler(
        IRepositoriAkun repositoriAkun,
        IRepositoriKas repositoriKas,
        IRepositoriPenerimaan repositoriPenerimaan,
        IUnitOfWork unitOfWork,
        IFileService fileService)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriKas = repositoriKas;
        _repositoriPenerimaan = repositoriPenerimaan;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<Result> Handle(CreatePenerimaanCommand request, CancellationToken cancellationToken)
    {
        var kas = await _repositoriKas.Get(request.IdKas);
        if (kas is null) return new Error("CreatePenerimaanCommandHandler.KasTidakDitemukan", $"Kas dengan Id : {request.IdKas} tidak ditemukan");

        var akun = await _repositoriAkun.Get(request.IdAkun);
        if (akun is null) return new Error("CreatePenerimaanCommandHandler.AkunTidakDitemukan", $"Akun dengan Id : {request.IdAkun} tidak ditemukan");

        if (akun.JenisAkun.Jenis != Jenis.Penerimaan)
            return new Error("CreatePenerimaanCommandHandler.BukanAkunPenerimaan", $"Akun {akun.Uraian} bukan akun jenis penerimaan");

        if (!_fileService.IsExist(request.FileBukti))
            return new Error("CreatePenerimaanCommandHandler.FileBuktiTidakAda", $"File Bukti {request.FileBukti.ToString()} tidak ditemukan");

        if (request.Jumlah < 0)
            return new Error("CreatePenerimaanCommandHandler.JumlahNegatif", "Jumlah penerimaan negatif");

        var penerimaan = new Penerimaan
        {
            Tanggal = request.Tanggal,
            Uraian = request.Uraian,
            FileBukti = request.FileBukti,
            Jumlah = request.Jumlah,
            Akun = akun,
            Kas = kas,
            SaldoKas = kas.Saldo + request.Jumlah
        };

        kas.Saldo += penerimaan.Jumlah;

        _repositoriPenerimaan.Add(penerimaan);
        _repositoriKas.Update(kas);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
