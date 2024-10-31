using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriAkun
{
    Task<Akun?> Get(int id);
    Task<List<Akun>> GetAll();
    Task<List<Akun>> GetAllByJenis(JenisAkun jenis);
    Task<List<Akun>> GetAllByKelompok(KelompokAkun kelompok);
    Task<List<Akun>> GetAllByGolongan(GolonganAkun golongan);

    void Add(Akun akun);
    void Delete(Akun akun);
    void Update(Akun akun);
}
