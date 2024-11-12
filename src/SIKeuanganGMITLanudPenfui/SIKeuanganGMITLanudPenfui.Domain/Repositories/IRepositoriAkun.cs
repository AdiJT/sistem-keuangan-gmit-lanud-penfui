using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriAkun
{
    Task<Akun?> Get(int id);
    Task<List<Akun>> GetAll();
    Task<List<Akun>> GetAllPenerimaan();
    Task<List<Akun>> GetAllBelanja();
    Task<List<Akun>> GetAllByJenis(JenisAkun jenis);
    Task<List<Akun>> GetAllByKelompok(KelompokAkun kelompok);
    Task<List<Akun>> GetAllByGolongan(GolonganAkun golongan);
    Task<List<Akun>> GetAllByTahun(Tahun tahun);
    Task<bool> IsExistOnTahun(Tahun tahun);

    void Add(Akun akun);
    void Delete(Akun akun);
    void Update(Akun akun);
}
