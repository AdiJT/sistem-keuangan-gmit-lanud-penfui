using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;

internal class CreateTransaksiCommandHandler : ICommandHandler<CreateTransaksiCommand>
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public CreateTransaksiCommandHandler(
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

    public async Task<Result> Handle(CreateTransaksiCommand request, CancellationToken cancellationToken)
    {
        //Validasi
        var akun = await _repositoriAkun.Get(request.AkunId);
        if (akun is null) return new Error("CreateTransaksiCommandHandler.AkunTidakDitemukan", $"Akun dengan Id {request.AkunId} tidak ditemukan");

        if(akun.JenisAkun.Jenis != request.Jenis)
            return new Error($"CreateTransaksiCommandHandler.BukanAkun{request.Jenis}", $"Akun {akun.Uraian} bukan akun {request.Jenis}");

        var kas = await _repositoriKas.Get(request.KasId);
        if (kas is null) return new Error("CreateTransaksiCommandHandler.KasTidakDitemukan", $"Kas dengan Id {request.KasId} tidak ditemukan");

        if (request.Jenis == Jenis.Belanja && kas.Saldo < request.Jumlah)
            return new Error("CreateTransaksiCommandHandler.SaldoKasTidakCukup", $"Saldo Kas {kas.Uraian} tidak cukup");

        if (request.Jumlah < 0)
            return new Error("CreateTransaksiCommandHandler.JumlahNegatif", "Jumlah transaksi tidak boleh negatif");

        if(!_fileService.IsExist(request.FileBukti))
            return new Error("CreateTransaksiCommandHandler.FileBuktiTidakAda", "File Bukti tidak ada");

        var tanggal = new DateTime(request.Tanggal.Year, request.Tanggal.Month, request.Tanggal.Day);
        if (request.Jam is not null)
            tanggal = new DateTime(
                request.Tanggal.Year,
                request.Tanggal.Month,
                request.Tanggal.Day,
                request.Jam.Value.Hour,
                request.Jam.Value.Minute,
                request.Jam.Value.Second);
        else
        {
            var transaksiTerbaru = (await _repositoriTransaksi.GetAll())
                .Where(t => t.Tanggal.Date == tanggal.Date)
                .OrderBy(t => t.Tanggal)
                .LastOrDefault();

            if (transaksiTerbaru is not null)
                tanggal = transaksiTerbaru.Tanggal.AddSeconds(1d);
        }

        //Cari saldo saat transaksi
        var daftarTransaksiSetelah = (await _repositoriTransaksi.GetAll()).Where(t => t.Tanggal > tanggal).OrderBy(t => t.Tanggal);
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
            saldoKasSebelumTransaksi = kas.Saldo;

        var saldoKasSetelahTransaksi = request.Jenis == Jenis.Penerimaan ? saldoKasSebelumTransaksi + request.Jumlah : saldoKasSebelumTransaksi - request.Jumlah;

        //Buat transaksi
        var transaksi = new Transaksi
        {
            Tanggal = tanggal,
            Uraian = request.Uraian,
            Jumlah = request.Jumlah,
            Jenis = request.Jenis,
            SaldoKas = saldoKasSetelahTransaksi,
            FileBukti = request.FileBukti,
            NomorBukti = request.NomorBukti,
            Akun = akun,
            Kas = kas
        };
        _repositoriTransaksi.Add(transaksi);

        //Update saldo kas
        kas.Saldo = request.Jenis == Jenis.Penerimaan ? kas.Saldo + request.Jumlah : kas.Saldo - request.Jumlah;
        _repositoriKas.Update(kas);

        //Update transaksi setelahnya
        foreach (var transaksiSetelah in daftarTransaksiSetelah)
        {
            saldoKasSetelahTransaksi = transaksiSetelah.Jenis == Jenis.Penerimaan ?
                saldoKasSetelahTransaksi + transaksiSetelah.Jumlah :
                saldoKasSetelahTransaksi - transaksiSetelah.Jumlah;

            transaksiSetelah.SaldoKas = saldoKasSetelahTransaksi;
            _repositoriTransaksi.Update(transaksiSetelah);
        }

        //Simpan perubahan
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
