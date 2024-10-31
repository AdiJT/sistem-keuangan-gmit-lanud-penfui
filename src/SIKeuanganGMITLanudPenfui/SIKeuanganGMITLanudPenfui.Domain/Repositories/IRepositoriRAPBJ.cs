using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriRAPBJ
{
    Task<RAPBJ?> Get(int tahun);
    Task<List<RAPBJ>> GetAll();

    void Add(RAPBJ rapbj);
    void Delete(RAPBJ rapbj);
    void Update(RAPBJ rapbj);
}
