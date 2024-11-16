using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriRAPBJ : IRepositoriRAPBJ
{
    private readonly AppDbContext _appDbContext;

    public RepositoriRAPBJ(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<RAPBJ?> Get(Tahun tahun) => await _appDbContext.TblRAPBJ
        .Include(r => r.DaftarDetailRAPBJ)
        .ThenInclude(d => d.Akun)
        .ThenInclude(a => a.JenisAkun)
        .ThenInclude(j => j.DaftarKelompokAkun)
        .ThenInclude(k => k.DaftarGolonganAkun)
        .FirstOrDefaultAsync(r => r.Tahun == tahun);

    public async Task<List<RAPBJ>> GetAll() => await _appDbContext.TblRAPBJ
        .Include(r => r.DaftarDetailRAPBJ).ToListAsync();

    public async Task<bool> IsExist(Tahun tahun) => await _appDbContext.TblRAPBJ.AnyAsync(r => r.Tahun == tahun);

    public void Add(RAPBJ rapbj) => _appDbContext.Add(rapbj);

    public void Delete(RAPBJ rapbj) => _appDbContext.Remove(rapbj);

    public void Update(RAPBJ rapbj) => _appDbContext.Update(rapbj);
}
