using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriTransaksi
{
    Task<Transaksi?> Get(int id);
    Task<Transaksi?> GetTerbaru();
    Task<List<Transaksi>> GetAll();
    Task<List<Transaksi>> GetAllByJenis(Jenis jenis);
    Task<List<Transaksi>> GetAllByTanggal(DateOnly tanggal);
    Task<List<Transaksi>> GetAllByTanggal(DateOnly tanggal, Jenis jenis);
    Task<List<Transaksi>> GetAllByMonth(int bulan);
    Task<List<Transaksi>> GetAllByMonth(int bulan, Jenis jenis);
    Task<List<Transaksi>> GetAllByTahun(int tahun);
    Task<List<Transaksi>> GetAllByTahun(int tahun, Jenis jenis);

    void Add(Transaksi transaksi);
    void Delete(Transaksi transaksi);
    void Update(Transaksi transaksi);
}
