using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriKelompokAkun
{
    Task<KelompokAkun?> Get(int id);
    Task<List<KelompokAkun>> GetAll();
    Task<List<KelompokAkun>> GetAllPenerimaan();
    Task<List<KelompokAkun>> GetAllBelanja();
    Task<List<KelompokAkun>> GetAllByJenis(JenisAkun jenis);

    void Add(KelompokAkun kelompokAkun);
    void Delete(KelompokAkun kelompokAkun);
    void Update(KelompokAkun kelompokAkun);
}
