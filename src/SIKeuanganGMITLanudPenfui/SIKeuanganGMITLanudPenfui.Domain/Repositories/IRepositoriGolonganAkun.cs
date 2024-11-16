using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriGolonganAkun
{
    Task<GolonganAkun?> Get(int id);
    Task<List<GolonganAkun>> GetAll();
    Task<List<GolonganAkun>> GetAllPenerimaan();
    Task<List<GolonganAkun>> GetAllBelanja();
    Task<List<GolonganAkun>> GetAllByKelompokAkun(KelompokAkun kelompok);
    Task<List<GolonganAkun>> GetAllByJenisAkun(JenisAkun jenis);
    Task<List<GolonganAkun>> GetAllByTahun(Tahun tahun);
    Task<string> GetKode(GolonganAkun golonganAkun);

    void Add(GolonganAkun golonganAkun);
    void Delete(GolonganAkun golonganAkun);
    void Update(GolonganAkun golonganAkun);
}