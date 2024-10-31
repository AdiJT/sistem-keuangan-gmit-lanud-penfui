using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriDetailRAPBJ : IRepositoriDetailRAPBJ
{
    private readonly AppDbContext _appDbContext;

    public RepositoriDetailRAPBJ(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(DetailRAPBJ detailRAPBJ) => _appDbContext.Add(detailRAPBJ);

    public void Delete(DetailRAPBJ detailRAPBJ) => _appDbContext.Remove(detailRAPBJ);

    public void Update(DetailRAPBJ detailRAPBJ) => _appDbContext.Update(detailRAPBJ);
}
