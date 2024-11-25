using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.BelanjaCQ.Commands.CreateBelanja;

internal class CreateBelanjaCommandHandler : ICommandHandler<CreateBelanjaCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriBelanja _repositoriBelanja;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public CreateBelanjaCommandHandler(
        IRepositoriAkun repositoriAkun,
        IRepositoriKas repositoriKas,
        IRepositoriBelanja repositoriBelanja,
        IUnitOfWork unitOfWork,
        IFileService fileService)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriKas = repositoriKas;
        _repositoriBelanja = repositoriBelanja;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<Result> Handle(CreateBelanjaCommand request, CancellationToken cancellationToken)
    {
        var kas = await _repositoriKas.Get(request.IdKas);
        if (kas is null) return new Error("CreateBelanjaCommandHandler.KasTidakDitemukan", $"Kas dengan Id {request.IdKas} tidak ditemukan");

        var akun = await _repositoriAkun.Get(request.IdAkun);
        if (akun is null) return new Error("CreateBelanjaCommandHandler.AkunTidakDitemukan", $"Akun dengan Id {request.IdAkun} tidak ditemukan");

        if (akun.JenisAkun.Jenis != Jenis.Belanja)
            return new Error("CreateBelanjaCommandHandler.BukanAkunBelanja", $"Akun {akun.Uraian} bukan akun belanja");

        if (request.Jumlah < 0)
            return new Error("CreateBelanjaCommandHandler.JumlahBelanjaNegatif", $"Jumlah belanja {request.Jumlah} negatif");

        if (kas.Saldo < request.Jumlah)
            return new Error("CreateBelanjaCommandHandler.SaldoKasTidakCukup", $"Saldo Kas {kas.Uraian} tidak cukup");

        if (!_fileService.IsExist(request.FileBukti))
            return new Error("CreateBelanjaCommandHandler.FileBuktiTidakDitemukan", $"File Bukti {request.FileBukti} tidak ada");

        var belanja = new Belanja
        {
            Jumlah = request.Jumlah,
            Akun = akun,
            Kas = kas,
            Tanggal = request.Tanggal,
            FileBukti = request.FileBukti,
            Uraian = request.Uraian,
            SaldoKas = kas.Saldo - request.Jumlah
        };
        kas.Saldo -= request.Jumlah;

        _repositoriBelanja.Add(belanja);
        _repositoriKas.Update(kas);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
