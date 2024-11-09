using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriKelompokAkun : IRepositoriKelompokAkun
{
    private readonly AppDbContext _appDbContext;

    public RepositoriKelompokAkun(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<KelompokAkun?> Get(int id) => await _appDbContext.TblKelompokAkun
        .Include(k => k.JenisAkun)
        .Include(k => k.DaftarAkun)
        .Include(k => k.DaftarGolonganAkun)
        .FirstOrDefaultAsync(k => k.Id == id);

    public async Task<List<KelompokAkun>> GetAllPenerimaan() => await _appDbContext.TblKelompokAkun
        .Include(k => k.JenisAkun)
        .Include(k => k.DaftarAkun)
        .Include(k => k.DaftarGolonganAkun)
        .Where(k => k.JenisAkun.Jenis == Jenis.Penerimaan)
        .ToListAsync();

    public async Task<List<KelompokAkun>> GetAllBelanja() => await _appDbContext.TblKelompokAkun
        .Include(k => k.JenisAkun)
        .Include(k => k.DaftarAkun)
        .Include(k => k.DaftarGolonganAkun)
        .Where(k => k.JenisAkun.Jenis == Jenis.Belanja)
        .ToListAsync();

    public async Task<List<KelompokAkun>> GetAll() => await _appDbContext.TblKelompokAkun
        .Include(k => k.JenisAkun)
        .Include(k => k.DaftarAkun)
        .Include(k => k.DaftarGolonganAkun).ToListAsync();

    public async Task<List<KelompokAkun>> GetAllByJenis(JenisAkun jenis) => await _appDbContext.TblKelompokAkun
        .Include(k => k.JenisAkun)
        .Include(k => k.DaftarAkun)
        .Include(k => k.DaftarGolonganAkun)
        .Where(k => k.JenisAkun == jenis)
        .ToListAsync();

    public void Add(KelompokAkun kelompokAkun) => _appDbContext.TblKelompokAkun.Add(kelompokAkun);

    public void Delete(KelompokAkun kelompokAkun) => _appDbContext.TblKelompokAkun.Remove(kelompokAkun);

    public void Update(KelompokAkun kelompokAkun) => _appDbContext.TblKelompokAkun.Update(kelompokAkun);
}
