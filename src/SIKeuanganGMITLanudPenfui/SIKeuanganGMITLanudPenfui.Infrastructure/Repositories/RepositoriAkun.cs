using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
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

    public async Task<List<Akun>> GetAllByJenis(JenisAkun jenis) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.JenisAkun.Id == jenis.Id)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByKelompok(KelompokAkun kelompok) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.KelompokAkun!= null && a.KelompokAkun.Id == kelompok.Id)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByGolongan(GolonganAkun golongan) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun)
        .Include(a => a.GolonganAkun)
        .Where(a => a.GolonganAkun != null && a.GolonganAkun.Id == golongan.Id)
        .ToListAsync();

    public void Add(Akun akun)
    {
        _appDbContext.TblAkun.Add(akun);
    }

    public void Delete(Akun akun)
    {
        _appDbContext.TblAkun.Remove(akun);
    }

    public void Update(Akun akun)
    {
        _appDbContext.TblAkun.Update(akun);
    }
}
