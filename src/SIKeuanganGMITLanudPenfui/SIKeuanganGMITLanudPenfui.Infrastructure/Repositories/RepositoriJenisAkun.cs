using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriJenisAkun : IRepositoriJenisAkun
{
    private readonly AppDbContext _appDbContext;

    public RepositoriJenisAkun(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<JenisAkun?> Get(int id) => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun).ThenInclude(a => a.DaftarDetailRAPBJ)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarKelompokAkun)
        .FirstOrDefaultAsync(j => j.Id == id);

    public async Task<JenisAkun?> GetByUraian(string uraian, Tahun tahun) => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarKelompokAkun)
        .FirstOrDefaultAsync(j => j.Uraian == uraian && j.Tahun == tahun);

    public async Task<List<JenisAkun>> GetAllPenerimaan() => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarKelompokAkun)
        .Where(j => j.Jenis == Jenis.Penerimaan)
        .ToListAsync();

    public async Task<List<JenisAkun>> GetAllBelanja() => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarKelompokAkun)
        .Where(j => j.Jenis == Jenis.Belanja)
        .ToListAsync();

    public async Task<List<JenisAkun>> GetAll() => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun).ThenInclude(a => a.DaftarDetailRAPBJ)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarKelompokAkun)
        .ToListAsync();

    public async Task<List<JenisAkun>> GetAllByTahun(Tahun tahun) => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun).ThenInclude(a => a.KelompokAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.GolonganAkun)
        .Include(j => j.DaftarAkun).ThenInclude(a => a.DaftarDetailRAPBJ)
        .Include(j => j.DaftarKelompokAkun).ThenInclude(a => a.DaftarAkun)
        .Include(j => j.DaftarKelompokAkun).ThenInclude(a => a.DaftarGolonganAkun)
        .Where(j => j.Tahun == tahun)
        .ToListAsync();

    public async Task<string> GetKode(JenisAkun jenisAkun)
    {
        var daftarJenisAkun = await _appDbContext
            .TblJenisAkun
            .Where(j => j.Jenis == jenisAkun.Jenis && j.Tahun == jenisAkun.Tahun)
            .OrderBy(j => j.Id)
            .ToListAsync();

        return $"{(jenisAkun.Jenis == Jenis.Penerimaan ? "I" : "II")}.{daftarJenisAkun.IndexOf(jenisAkun) + 1}";
    }

    public void Add(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Add(jenisAkun);

    public void Delete(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Remove(jenisAkun);

    public void Update(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Update(jenisAkun);

    public async Task<bool> IsUraianUnique(string uraian, Tahun tahun) => !await _appDbContext.TblJenisAkun
        .AnyAsync(j => j.Tahun == tahun && j.Uraian == uraian);
}
