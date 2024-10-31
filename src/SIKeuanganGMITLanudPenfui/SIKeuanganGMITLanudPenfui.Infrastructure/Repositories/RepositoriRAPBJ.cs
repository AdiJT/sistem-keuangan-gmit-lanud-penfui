using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriRAPBJ : IRepositoriRAPBJ
{
    private readonly AppDbContext _appDbContext;

    public RepositoriRAPBJ(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<RAPBJ?> Get(int tahun) => await _appDbContext.TblRAPBJ
        .Include(r => r.DaftarDetailRAPBJ)
        .FirstOrDefaultAsync(r => r.Tahun == tahun);

    public async Task<List<RAPBJ>> GetAll() => await _appDbContext.TblRAPBJ
        .Include(r => r.DaftarDetailRAPBJ).ToListAsync();

    public void Add(RAPBJ rapbj) => _appDbContext.Add(rapbj);

    public void Delete(RAPBJ rapbj) => _appDbContext.Remove(rapbj);

    public void Update(RAPBJ rapbj) => _appDbContext.Update(rapbj);
}
