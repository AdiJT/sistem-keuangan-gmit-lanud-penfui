using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriTransaksi : IRepositoriTransaksi
{
    private readonly AppDbContext _appDbContext;

    public RepositoriTransaksi(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Transaksi?> Get(int id) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .FirstOrDefaultAsync(t => t.Id == id);

    public async Task<Transaksi?> GetTerbaru() => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .OrderBy(t => t.Tanggal)
        .LastOrDefaultAsync();

    public async Task<List<Transaksi>> GetAll() => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByJenis(Jenis jenis) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Jenis == jenis)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByMonth(int bulan) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Tanggal.Month == bulan)
        .OrderBy(t => t.Tanggal)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByMonth(int bulan, Jenis jenis) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Jenis == jenis && t.Tanggal.Month == bulan)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByTahun(int tahun) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Where(t => t.Tanggal.Year == tahun)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByTahun(int tahun, Jenis jenis) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Jenis == jenis && t.Tanggal.Year == tahun)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByTanggal(DateTime tanggal) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Tanggal == tanggal)
        .ToListAsync();

    public async Task<List<Transaksi>> GetAllByTanggal(DateTime tanggal, Jenis jenis) => await _appDbContext.TblTransaksi
        .Include(t => t.Kas)
        .Include(t => t.Akun).ThenInclude(a => a.JenisAkun)
        .Include(t => t.Akun).ThenInclude(a => a.KelompokAkun)
        .Include(t => t.Akun).ThenInclude(a => a.GolonganAkun)
        .Where(t => t.Jenis == jenis && t.Tanggal == tanggal)
        .ToListAsync();

    public void Add(Transaksi transaksi) => _appDbContext.TblTransaksi.Add(transaksi);

    public void Delete(Transaksi transaksi) => _appDbContext.TblTransaksi.Remove(transaksi);

    public void Update(Transaksi transaksi) => _appDbContext.TblTransaksi.Update(transaksi);
}
