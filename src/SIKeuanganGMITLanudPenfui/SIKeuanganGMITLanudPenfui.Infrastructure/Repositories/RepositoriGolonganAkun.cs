﻿using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriGolonganAkun : IRepositoriGolonganAkun
{
    private readonly AppDbContext _appDbContext;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;

    public RepositoriGolonganAkun(AppDbContext appDbContext, IRepositoriKelompokAkun repositoriKelompokAkun)
    {
        _appDbContext = appDbContext;
        _repositoriKelompokAkun = repositoriKelompokAkun;
    }

    public async Task<GolonganAkun?> Get(int id) => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .FirstOrDefaultAsync(g => g.Id == id);

    public async Task<List<GolonganAkun>> GetAllPenerimaan() => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Where(g => g.KelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan)
        .ToListAsync();

    public async Task<List<GolonganAkun>> GetAllBelanja() => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Where(g => g.KelompokAkun.JenisAkun.Jenis == Jenis.Belanja)
        .ToListAsync();

    public async Task<List<GolonganAkun>> GetAll() => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ToListAsync();

    public async Task<List<GolonganAkun>> GetAllByJenisAkun(JenisAkun jenis) => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Where(g => g.KelompokAkun.JenisAkun == jenis)
        .ToListAsync();

    public async Task<List<GolonganAkun>> GetAllByKelompokAkun(KelompokAkun kelompok) => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Where(g => g.KelompokAkun == kelompok)
        .ToListAsync();

    public async Task<List<GolonganAkun>> GetAllByTahun(Tahun tahun) => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Where(g => g.Tahun == tahun)
        .ToListAsync();

    public async Task<string> GetKode(GolonganAkun golonganAkun)
    {
        var kodeKelompokAkun = await _repositoriKelompokAkun.GetKode(golonganAkun.KelompokAkun);

        var daftarGolonganAkun = await _appDbContext
            .TblGolonganAkun
            .Where(g => g.KelompokAkun == golonganAkun.KelompokAkun)
            .OrderBy(g => g.Id)
            .ToListAsync();

        var jumlahAkun = await _appDbContext
            .TblAkun
            .Where(a => a.KelompokAkun != null && a.KelompokAkun == golonganAkun.KelompokAkun)
            .CountAsync();

        return $"{kodeKelompokAkun}.{jumlahAkun + daftarGolonganAkun.IndexOf(golonganAkun) + 1}";
    }

    public void Add(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Add(golonganAkun);

    public void Delete(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Remove(golonganAkun);

    public void Update(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Update(golonganAkun);
}
