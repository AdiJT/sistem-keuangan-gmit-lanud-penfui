using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriTransaksi
{
    Task<Transaksi?> Get(int id);
    Task<Transaksi?> GetTerbaru();
    Task<List<Transaksi>> GetAll();
    Task<List<Transaksi>> GetAllByJenis(Jenis jenis);
    Task<List<Transaksi>> GetAllByTanggal(DateTime tanggal);
    Task<List<Transaksi>> GetAllByTanggal(DateTime tanggal, Jenis jenis);
    Task<List<Transaksi>> GetAllByMonth(int bulan);
    Task<List<Transaksi>> GetAllByMonth(int bulan, Jenis jenis);
    Task<List<Transaksi>> GetAllByTahun(int tahun);
    Task<List<Transaksi>> GetAllByTahun(int tahun, Jenis jenis);
    Task<List<Transaksi>> GetAllPanjar();
    Task<List<Transaksi>> GetAllPanjarByTahun(int tahun);
    Task<List<Transaksi>> GetAllPanjarByMonth(int bulan);
    Task<List<Transaksi>> GetAllPanjarByTanggal(DateTime tanggal);

    void Add(Transaksi transaksi);
    void Delete(Transaksi transaksi);
    void Update(Transaksi transaksi);
}
