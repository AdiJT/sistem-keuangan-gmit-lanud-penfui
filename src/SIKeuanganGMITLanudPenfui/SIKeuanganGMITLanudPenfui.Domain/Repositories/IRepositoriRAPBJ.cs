using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriRAPBJ
{
    Task<RAPBJ?> Get(Tahun tahun);
    Task<List<RAPBJ>> GetAll();
    Task<bool> IsExist(Tahun tahun);

    void Add(RAPBJ rapbj);
    void Delete(RAPBJ rapbj);
    void Update(RAPBJ rapbj);
}
