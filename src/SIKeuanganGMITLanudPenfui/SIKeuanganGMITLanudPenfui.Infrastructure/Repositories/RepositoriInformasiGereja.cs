using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriInformasiGereja : IRepositoriInformasiGereja
{
    private readonly AppDbContext _appDbContext;

    public RepositoriInformasiGereja(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<InformasiGereja?> Get(Tahun tahun) => await _appDbContext.TblInformasiGereja.FirstOrDefaultAsync(i => i.Tahun == tahun);

    public async Task<List<InformasiGereja>> GetAll() => await _appDbContext.TblInformasiGereja.ToListAsync();

    public async Task<bool> IsDuplicate(Tahun tahun) => await _appDbContext.TblInformasiGereja.AnyAsync(i => i.Tahun == tahun);

    public void Add(InformasiGereja informasiGereja) => _appDbContext.TblInformasiGereja.Add(informasiGereja);

    public void Delete(InformasiGereja informasiGereja) => _appDbContext.TblInformasiGereja.Remove(informasiGereja);

    public void Update(InformasiGereja informasiGereja) => _appDbContext.TblInformasiGereja.Update(informasiGereja);
}