using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriJenisAkun
{
    Task<JenisAkun?> Get(int id);
    Task<JenisAkun?> GetByUraian(string uraian);
    Task<List<JenisAkun>> GetAll();
    Task<List<JenisAkun>> GetAllPenerimaan();
    Task<List<JenisAkun>> GetAllBelanja();

    void Add(JenisAkun jenisAkun);
    void Delete(JenisAkun jenisAkun);
    void Update(JenisAkun jenisAkun);
}
