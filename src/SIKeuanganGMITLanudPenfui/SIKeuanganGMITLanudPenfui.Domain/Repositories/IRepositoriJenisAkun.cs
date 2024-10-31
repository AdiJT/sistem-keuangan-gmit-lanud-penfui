using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriJenisAkun
{
    Task<JenisAkun?> Get(int id);
    Task<List<JenisAkun>> GetAll();

    void Add(JenisAkun jenisAkun);
    void Delete(JenisAkun jenisAkun);
    void Update(JenisAkun jenisAkun);
}
