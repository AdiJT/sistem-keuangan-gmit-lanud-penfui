using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriBelanja : IRepositoriBelanja
{
    private readonly AppDbContext _appDbContext;

    public RepositoriBelanja(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Belanja?> Get(int id) => await _appDbContext.TblBelanja
        .Include(b => b.Akun)
        .FirstOrDefaultAsync(b => b.Id == id);

    public async Task<List<Belanja>> GetAll() => await _appDbContext.TblBelanja
        .Include(b => b.Akun)
        .ToListAsync();

    public async Task<List<Belanja>> GetAllByMonth(int bulan) => await _appDbContext.TblBelanja
        .Include(b => b.Akun)
        .Where(b => b.Tanggal.Month == bulan)
        .ToListAsync();

    public async Task<List<Belanja>> GetAllByTahun(int tahun) => await _appDbContext.TblBelanja
        .Include(b => b.Akun)
        .Where(b => b.Tanggal.Year == tahun)
        .ToListAsync();

    public async Task<List<Belanja>> GetAllByTanggal(DateOnly tanggal) => await _appDbContext.TblBelanja
        .Include(b => b.Akun)
        .Where(b => b.Tanggal == tanggal)
        .ToListAsync();

    public void Add(Belanja belanja) => _appDbContext.TblBelanja.Add(belanja);

    public void Delete(Belanja belanja) => _appDbContext.TblBelanja.Remove(belanja);

    public void Update(Belanja belanja) => _appDbContext.TblBelanja.Update(belanja);
}
