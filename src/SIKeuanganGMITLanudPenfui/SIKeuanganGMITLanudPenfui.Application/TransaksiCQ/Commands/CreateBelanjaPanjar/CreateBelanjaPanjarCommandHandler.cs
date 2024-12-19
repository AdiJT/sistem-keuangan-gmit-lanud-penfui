using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateBelanjaPanjar;

internal class CreateBelanjaPanjarCommandHandler : ICommandHandler<CreateBelanjaPanjarCommand>
{
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateBelanjaPanjarCommandHandler(
        IRepositoriTransaksi repositoriTransaksi,
        IRepositoriKas repositoriKas,
        IRepositoriAkun repositoriAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriTransaksi = repositoriTransaksi;
        _repositoriKas = repositoriKas;
        _repositoriAkun = repositoriAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateBelanjaPanjarCommand request, CancellationToken cancellationToken)
    {
        //Validasi
        var akun = await _repositoriAkun.Get(request.AkunId);
        if (akun is null) return new Error("CreateBelanjaPanjarCommandHandler.AkunTidakDitemukan", $"Akun dengan Id {request.AkunId} tidak ditemukan");

        if (akun.JenisAkun.Jenis != Jenis.Belanja)
            return new Error($"CreateBelanjaPanjarCommandHandler.BukanAkunBelanja", $"Akun {akun.Uraian} bukan akun Belanja");

        var kas = await _repositoriKas.Get(request.KasId);
        if (kas is null) return new Error("CreateBelanjaPanjarCommandHandler.KasTidakDitemukan", $"Kas dengan Id {request.KasId} tidak ditemukan");

        if (request.Jumlah < 0)
            return new Error("CreateBelanjaPanjarCommandHandler.JumlahNegatif", "Jumlah transaksi tidak boleh negatif");

        if (kas.Saldo < request.Jumlah)
            return new Error("CreateBelanjaPanjarCommandHandler.SaldoKasTidakCukup", $"Saldo Kas {kas.Uraian} tidak cukup");
        
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
        var daftarTransaksiSetelah = (await _repositoriTransaksi.GetAll())
            .Where(t => t.Tanggal > tanggal && t.Kas == kas)
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
            saldoKasSebelumTransaksi = kas.Saldo;

        var saldoKasSetelahTransaksi = saldoKasSebelumTransaksi - request.Jumlah;

        //Buat transaksi
        var transaksi = new Transaksi
        {
            Tanggal = tanggal,
            Uraian = request.Uraian,
            Jumlah = request.Jumlah,
            Jenis = Jenis.Belanja,
            SaldoKas = saldoKasSetelahTransaksi,
            Akun = akun,
            Kas = kas,
            StatusTransaksi = StatusTransaksi.Panjar
        };
        _repositoriTransaksi.Add(transaksi);

        //Update transaksi setelahnya
        foreach (var transaksiSetelah in daftarTransaksiSetelah)
        {
            saldoKasSetelahTransaksi = saldoKasSetelahTransaksi - transaksiSetelah.Jumlah;

            transaksiSetelah.SaldoKas = saldoKasSetelahTransaksi;
            _repositoriTransaksi.Update(transaksiSetelah);
        }

        //Simpan perubahan
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
