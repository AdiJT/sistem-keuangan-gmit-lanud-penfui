﻿using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriGolonganAkun : IRepositoriGolonganAkun
{
    private readonly AppDbContext _appDbContext;

    public RepositoriGolonganAkun(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<GolonganAkun?> Get(int id) => await _appDbContext.TblGolonganAkun
        .Include(g => g.DaftarAkun)
        .Include(g => g.KelompokAkun)
        .FirstOrDefaultAsync(g => g.Id == id);

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
        .Include(g => g.KelompokAkun)
        .Where(g => g.KelompokAkun == kelompok)
        .ToListAsync();

    public void Add(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Add(golonganAkun);

    public void Delete(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Remove(golonganAkun);

    public void Update(GolonganAkun golonganAkun) => _appDbContext.TblGolonganAkun.Update(golonganAkun);
}
