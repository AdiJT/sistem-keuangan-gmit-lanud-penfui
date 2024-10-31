using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriPenerimaan
{
    Task<Penerimaan?> Get(int id);
    Task<Penerimaan?> GetByTanggal(DateOnly dateOnly);
    Task<List<Penerimaan>> GetAll();
    Task<List<Penerimaan>> GetAllByMonth(int month);
    Task<List<Penerimaan>> GetAllByTahun(int tahun);

    void Add(Penerimaan penerimaan);
    void Delete(Penerimaan penerimaan);
    void Update(Penerimaan penerimaan);
}
