using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriKas : IRepositoriKas
{
    private readonly AppDbContext _appDbContext;

    public RepositoriKas(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Kas?> Get(int id) => await _appDbContext.TblKas.FirstOrDefaultAsync(k => k.Id == id);

    public async Task<List<Kas>> GetAll() => await _appDbContext.TblKas.ToListAsync();

    public void Add(Kas kas) => _appDbContext.TblKas.Add(kas);

    public void Delete(Kas kas) => _appDbContext.TblKas.Remove(kas);

    public void Update(Kas kas) => _appDbContext.TblKas.Update(kas);
}