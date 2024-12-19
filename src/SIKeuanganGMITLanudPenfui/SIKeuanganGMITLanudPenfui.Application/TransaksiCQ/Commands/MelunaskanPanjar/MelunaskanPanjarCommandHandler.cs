using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.MelunaskanPanjar;

internal class MelunaskanPanjarCommandHandler : ICommandHandler<MelunaskanPanjarCommand>
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public MelunaskanPanjarCommandHandler(
        IRepositoriTransaksi repositoriTransaksi,
        IRepositoriKas repositoriKas,
        IRepositoriAkun repositoriAkun,
        IUnitOfWork unitOfWork,
        IFileService fileService)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _repositoriKas = repositoriKas;
        _repositoriAkun = repositoriAkun;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<Result> Handle(MelunaskanPanjarCommand request, CancellationToken cancellationToken)
    {
        //Validasi
        var transaksi = await _repositoriTransaksi.Get(request.IdTransaksi);
        if (transaksi is null)
            return new Error("MelunaskanPanjarCommandHandler.TransaksiTidakDitemukan", $"Transaksi dengan Id : {request.IdTransaksi} tidak ditemukan");

        if(transaksi.Jenis != Jenis.Belanja)
            return new Error("MelunaskanPanjarCommandHandler.BukanTransaksiBelanja", 
                $"Transaksi dengan Id : {request.IdTransaksi} bukan transaksi belanja");

        if(transaksi.StatusTransaksi != StatusTransaksi.Panjar)
            return new Error("MelunaskanPanjarCommandHandler.TransaksiSudahLunas", $"Transaksi dengan Id : {request.IdTransaksi} sudah lunas");

        if(!_fileService.IsExist(request.FileBukti))
            return new Error("MelunaskanPanjarCommandHandler.FileBuktiTidakDitemukan", $"File Bukti tidak ditemukan");

        //Cari saldo saat transaksi
        var daftarTransaksiSetelah = (await _repositoriTransaksi.GetAll())
            .Where(t => t.Tanggal > transaksi.Tanggal && t.Kas == transaksi.Kas)
            .OrderBy(t => t.Tanggal);

        var transaksiTerdekat = daftarTransaksiSetelah.FirstOrDefault();
        var saldoKasSebelumTransaksi = 0d;

        if (transaksiTerdekat is not null)
        {
            if (transaksiTerdekat.Jenis == Jenis.Penerimaan)
                saldoKasSebelumTransaksi = transaksiTerdekat.SaldoKas - transaksiTerdekat.Jumlah;
            else
                saldoKasSebelumTransaksi = transaksiTerdekat.SaldoKas + transaksiTerdekat.Jumlah;
        }
        else
            saldoKasSebelumTransaksi = transaksi.Kas.Saldo;

        var saldoKasSetelahTransaksi = saldoKasSebelumTransaksi - request.Jumlah;

        //Update Transaksi
        transaksi.Jumlah = request.Jumlah;
        transaksi.SaldoKas = saldoKasSetelahTransaksi;
        transaksi.StatusTransaksi = StatusTransaksi.Lunas;

        _repositoriTransaksi.Update(transaksi);

        //Update saldo kas
        transaksi.Kas.Saldo -= request.Jumlah;
        _repositoriKas.Update(transaksi.Kas);

        //Update transaksi setelahnya
        foreach (var transaksiSetelah in daftarTransaksiSetelah)
        {
            saldoKasSetelahTransaksi -= transaksiSetelah.Jumlah;

            transaksiSetelah.SaldoKas = saldoKasSetelahTransaksi;
            _repositoriTransaksi.Update(transaksiSetelah);
        }

        //Simpan perubahan
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
