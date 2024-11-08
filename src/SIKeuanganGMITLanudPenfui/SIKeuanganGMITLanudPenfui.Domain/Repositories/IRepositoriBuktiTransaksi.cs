using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriBuktiTransaksi
{
    Task<BuktiTransaksi?> Get(int id);
    Task<List<BuktiTransaksi>> GetAll();

    void Add(BuktiTransaksi buktiTransaksi);
    void Update(BuktiTransaksi buktiTransaksi);
    void Delete(BuktiTransaksi buktiTransaksi);
}
