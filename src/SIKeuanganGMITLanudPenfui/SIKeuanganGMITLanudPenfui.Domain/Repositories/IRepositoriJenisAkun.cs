using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriJenisAkun
{
    Task<JenisAkun?> Get(int id);
    Task<JenisAkun?> GetByUraian(string uraian, Tahun tahun);
    Task<List<JenisAkun>> GetAll();
    Task<List<JenisAkun>> GetAllPenerimaan();
    Task<List<JenisAkun>> GetAllBelanja();
    Task<bool> IsUraianUnique(string uraian, Tahun tahun);
    Task<List<JenisAkun>> GetAllByTahun(Tahun tahun);

    void Add(JenisAkun jenisAkun);
    void Delete(JenisAkun jenisAkun);
    void Update(JenisAkun jenisAkun);
}
