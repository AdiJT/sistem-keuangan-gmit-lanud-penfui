using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriPenerimaan
{
    Task<Penerimaan?> Get(int id);
    Task<List<Penerimaan>> GetAll();
    Task<List<Penerimaan>> GetAllByMonth(int bulan);
    Task<List<Penerimaan>> GetAllByTahun(int tahun);
    Task<List<Penerimaan>> GetAllByTanggal(DateOnly tanggal);

    void Add(Penerimaan penerimaan);
    void Delete(Penerimaan penerimaan);
    void Update(Penerimaan penerimaan);
}
