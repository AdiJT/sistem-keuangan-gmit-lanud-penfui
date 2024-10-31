using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriPenerimaan : IRepositoriPenerimaan
{
    private readonly AppDbContext _appDbContext;

    public RepositoriPenerimaan(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Penerimaan?> Get(int id) => await _appDbContext.TblPenerimaan
        .Include(p => p.Akun)
        .FirstOrDefaultAsync(p => p.Id == id);

    public async Task<List<Penerimaan>> GetAll() => await _appDbContext.TblPenerimaan
        .Include(p => p.Akun)
        .ToListAsync();

    public async Task<List<Penerimaan>> GetAllByMonth(int bulan) => await _appDbContext.TblPenerimaan
        .Include(p => p.Akun)
        .Where(p => p.Tanggal.Month == bulan)
        .ToListAsync();

    public async Task<List<Penerimaan>> GetAllByTahun(int tahun) => await _appDbContext.TblPenerimaan
        .Include(p => p.Akun)
        .Where(p => p.Tanggal.Year == tahun)
        .ToListAsync();

    public async Task<List<Penerimaan>> GetAllByTanggal(DateOnly tanggal) => await _appDbContext.TblPenerimaan
        .Include(p => p.Akun)
        .Where(p => p.Tanggal == tanggal)
        .ToListAsync();

    public void Add(Penerimaan penerimaan) => _appDbContext.TblPenerimaan.Add(penerimaan);

    public void Delete(Penerimaan penerimaan) => _appDbContext.TblPenerimaan.Remove(penerimaan);

    public void Update(Penerimaan penerimaan) => _appDbContext.TblPenerimaan.Update(penerimaan);
}
