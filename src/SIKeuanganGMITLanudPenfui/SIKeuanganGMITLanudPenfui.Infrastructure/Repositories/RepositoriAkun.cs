﻿using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriAkun : IRepositoriAkun
{
    private readonly AppDbContext _appDbContext;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;

    public RepositoriAkun(
        AppDbContext appDbContext,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun)
    {
        _appDbContext = appDbContext;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
    }

    public async Task<Akun?> Get(int id) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .FirstOrDefaultAsync(a => a.Id == id);

    public async Task<List<Akun>> GetAll() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .ToListAsync();

    public async Task<List<Akun>> GetAllPenerimaan() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.JenisAkun.Jenis == Jenis.Penerimaan)
        .ToListAsync();

    public async Task<List<Akun>> GetAllBelanja() => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.JenisAkun.Jenis == Jenis.Belanja)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByJenis(JenisAkun jenis) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.JenisAkun == jenis)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByKelompok(KelompokAkun kelompok) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.KelompokAkun == kelompok || (a.GolonganAkun != null && a.GolonganAkun.KelompokAkun == kelompok))
        .ToListAsync();

    public async Task<List<Akun>> GetAllByGolongan(GolonganAkun golongan) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.GolonganAkun != null && a.GolonganAkun == golongan)
        .ToListAsync();

    public async Task<List<Akun>> GetAllByTahun(Tahun tahun) => await _appDbContext.TblAkun
        .Include(a => a.JenisAkun)
        .Include(a => a.KelompokAkun).ThenInclude(k => k.JenisAkun)
        .Include(a => a.GolonganAkun).ThenInclude(g => g.KelompokAkun)
        .Include(a => a.DaftarDetailRAPBJ)
        .Where(a => a.Tahun == tahun)
        .ToListAsync();

    public async Task<bool> IsExistOnTahun(Tahun tahun) => 
        await _appDbContext.TblAkun.AnyAsync(a => a.Tahun == tahun) ||
        await _appDbContext.TblJenisAkun.AnyAsync(j => j.Tahun == tahun) ||
        await _appDbContext.TblKelompokAkun.AnyAsync(k => k.Tahun == tahun) ||
        await _appDbContext.TblGolonganAkun.AnyAsync(g => g.Tahun == tahun);

    public async Task<string> GetKode(Akun akun)
    {
        if(akun.KelompokAkun is null && akun.GolonganAkun is null)
        {
            var kodeJenisAkun = await _repositoriJenisAkun.GetKode(akun.JenisAkun);
            var daftarAkun = await _appDbContext.TblAkun
                .Where(a => a.JenisAkun == akun.JenisAkun && a.KelompokAkun == null && a.GolonganAkun == null)
                .OrderBy(a => a.Id)
                .ToListAsync();

            return $"{kodeJenisAkun}.{daftarAkun.IndexOf(akun) + 1}";
        } 
        else if(akun.KelompokAkun is not null && akun.GolonganAkun is null)
        {
            var kodeKelompokAkun = await _repositoriKelompokAkun.GetKode(akun.KelompokAkun);
            var daftarAkun = await _appDbContext.TblAkun
                .Where(a => a.KelompokAkun == akun.KelompokAkun)
                .OrderBy(a => a.Id)
                .ToListAsync();

            return $"{kodeKelompokAkun}.{daftarAkun.IndexOf(akun) + 1}";
        }
        else
        {
            var kodeGolonganAkun = await _repositoriGolonganAkun.GetKode(akun.GolonganAkun!);
            var daftarAkun = await _appDbContext.TblAkun
                .Where(a => a.GolonganAkun == akun.GolonganAkun)
                .OrderBy(a => a.Id)
                .ToListAsync();

            return $"{kodeGolonganAkun}.{daftarAkun.IndexOf(akun) + 1}";
        }
    }

    public void Add(Akun akun) => _appDbContext.TblAkun.Add(akun);

    public void Delete(Akun akun)
    {
        _appDbContext.TblAkun.Remove(akun);
    }

    public void Update(Akun akun)
    {
        _appDbContext.TblAkun.Update(akun);
    }
}
