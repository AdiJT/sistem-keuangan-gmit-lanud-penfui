using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.HapusTransaksi;

internal class HapusTransaksiCommandHandler : ICommandHandler<HapusTransaksiCommand>
{
    private readonly IRepositoriKas _repositoriKas;
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IUnitOfWork _unitOfWork;

    public HapusTransaksiCommandHandler(IRepositoriKas repositoriKas, IRepositoriTransaksi repositoriTransaksi, IUnitOfWork unitOfWork)
    {
        _repositoriKas = repositoriKas;
        _repositoriTransaksi = repositoriTransaksi;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(HapusTransaksiCommand request, CancellationToken cancellationToken)
    {
        var transaksi = await _repositoriTransaksi.Get(request.IdTransaksi);
        if (transaksi is null)
            return new Error("HapusTransaksiCommandHandler.TransaksiTidakDitemukan", $"Transaksi {request.IdTransaksi} tidak ditemukan");

        var daftarTransaksiSetelah = (await _repositoriTransaksi.GetAll()).Where(t => t.Tanggal >= transaksi.Tanggal).OrderBy(t => t.Tanggal);
        var saldoSebelumTransaksi = transaksi.Jenis == Jenis.Penerimaan ? transaksi.SaldoKas - transaksi.Jumlah : transaksi.SaldoKas + transaksi.Jumlah;

        foreach (var transaksiSetelah in daftarTransaksiSetelah)
        {
            saldoSebelumTransaksi = transaksiSetelah.Jenis == Jenis.Penerimaan ? 
                saldoSebelumTransaksi + transaksiSetelah.Jumlah : 
                saldoSebelumTransaksi - transaksiSetelah.Jumlah;

            transaksiSetelah.SaldoKas = saldoSebelumTransaksi;
            _repositoriTransaksi.Update(transaksiSetelah); 
        }

        transaksi.Kas.Saldo = transaksi.Jenis == Jenis.Penerimaan ? transaksi.Kas.Saldo - transaksi.Jumlah : transaksi.Kas.Saldo + transaksi.Jumlah;
        _repositoriKas.Update(transaksi.Kas);
        _repositoriTransaksi.Delete(transaksi);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
