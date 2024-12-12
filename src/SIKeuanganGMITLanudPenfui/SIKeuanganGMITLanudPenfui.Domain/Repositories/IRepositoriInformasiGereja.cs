using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriInformasiGereja
{
    Task<InformasiGereja?> Get(Tahun tahun);
    Task<List<InformasiGereja>> GetAll();
    Task<bool> IsDuplicate(Tahun tahun);

    void Add(InformasiGereja informasiGereja);
    void Update(InformasiGereja informasiGereja);
    void Delete(InformasiGereja informasiGereja);
}
