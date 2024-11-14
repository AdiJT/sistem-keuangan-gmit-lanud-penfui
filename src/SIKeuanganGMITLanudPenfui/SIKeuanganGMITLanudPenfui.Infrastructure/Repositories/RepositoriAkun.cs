using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriAkun : IRepositoriAkun
{
    private readonly AppDbContext _appDbContext;

    public RepositoriAkun(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Akun?> Get(int id) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .FirstOrDefaultAsync(a => a.Id == id);

    public async Task<List<Akun>> GetAll() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .ToListAsync();

    public async Task<List<Akun>> GetAllPenerimaan() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.JenisAkun.Jenis == Jenis.Penerimaan)
        .ToListAsync();

    public async Task<List<Akun>> GetAllBelanja() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.JenisAkun.Jenis == Jenis.Belanja)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByJenis(JenisAkun jenis) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.JenisAkun == jenis)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByKelompok(KelompokAkun kelompok) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Where(a => a.KelompokAkun == kelompok || (a.GolonganAkun != null && a.GolonganAkun.KelompokAkun == kelompok))
        .ToListAsync();

    public async Task<List<Akun>> GetAllByGolongan(GolonganAkun golongan) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.GolonganAkun != null && a.GolonganAkun == golongan)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByTahun(Tahun tahun) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.Tahun == tahun)
        .ToListAsync();

    public async Task<bool> IsExistOnTahun(Tahun tahun) => 
        await _appDbContext.TblAkun.AnyAsync(a => a.Tahun == tahun) ||
        await _appDbContext.TblJenisAkun.AnyAsync(j => j.Tahun == tahun) ||
        await _appDbContext.TblKelompokAkun.AnyAsync(k => k.Tahun == tahun) ||
        await _appDbContext.TblGolonganAkun.AnyAsync(g => g.Tahun == tahun);

    public void Add(Akun akun) => _appDbContext.TblAkun.Add(akun);

    public void Delete(Akun akun)
    {
        _appDbContext.TblAkun.Remove(akun);
    }

    public void Update(Akun akun)
    {
        _appDbContext.TblAkun.Update(akun);
    }
}
