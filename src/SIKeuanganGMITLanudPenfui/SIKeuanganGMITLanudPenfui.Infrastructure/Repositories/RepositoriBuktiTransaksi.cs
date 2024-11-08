using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriBuktiTransaksi : IRepositoriBuktiTransaksi
{
    private readonly AppDbContext _appDbContext;

    public RepositoriBuktiTransaksi(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<BuktiTransaksi?> Get(int id) => await _appDbContext.TblBuktiTransaksi.FirstOrDefaultAsync(b => b.Id == id);

    public async Task<List<BuktiTransaksi>> GetAll() => await _appDbContext.TblBuktiTransaksi.ToListAsync();

    public void Add(BuktiTransaksi buktiTransaksi) => _appDbContext.TblBuktiTransaksi.Add(buktiTransaksi);

    public void Delete(BuktiTransaksi buktiTransaksi) => _appDbContext.TblBuktiTransaksi.Remove(buktiTransaksi);

    public void Update(BuktiTransaksi buktiTransaksi) => _appDbContext.TblBuktiTransaksi.Update(buktiTransaksi);
}
