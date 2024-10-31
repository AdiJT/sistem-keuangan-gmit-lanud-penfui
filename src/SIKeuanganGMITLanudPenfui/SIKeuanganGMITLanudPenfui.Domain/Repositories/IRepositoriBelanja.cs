using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriBelanja
{
    Task<Belanja?> Get(int id);
    Task<List<Belanja>> GetAll();
    Task<List<Belanja>> GetAllByTanggal(DateOnly tanggal);
    Task<List<Belanja>> GetAllByMonth(int bulan);
    Task<List<Belanja>> GetAllByTahun(int tahun);

    void Add(Belanja belanja);
    void Delete(Belanja belanja);
    void Update(Belanja belanja);
}