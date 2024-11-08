using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriKas
{
    Task<Kas?> Get(int id);
    Task<List<Kas>> GetAll();

    void Add(Kas kas);
    void Update(Kas kas);
    void Delete(Kas kas);
}
