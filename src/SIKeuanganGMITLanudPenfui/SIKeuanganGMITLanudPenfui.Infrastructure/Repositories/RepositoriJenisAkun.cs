using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
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
        .Include(j => j.DaftarAkun)
        .Include(j => j.DaftarKelompokAkun)
        .FirstOrDefaultAsync(j => j.Id == id);

    public async Task<List<JenisAkun>> GetAll() => await _appDbContext.TblJenisAkun
        .Include(j => j.DaftarAkun)
        .Include(j => j.DaftarKelompokAkun)
        .ToListAsync();

    public void Add(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Add(jenisAkun);

    public void Delete(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Remove(jenisAkun);

    public void Update(JenisAkun jenisAkun) => _appDbContext.TblJenisAkun.Update(jenisAkun);
}
