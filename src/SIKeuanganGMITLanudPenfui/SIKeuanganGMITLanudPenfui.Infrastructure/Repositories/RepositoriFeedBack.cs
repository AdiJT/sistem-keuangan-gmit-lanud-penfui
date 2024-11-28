using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriFeedBack : IRepositoriFeedBack
{
    private readonly AppDbContext _appDbContext;

    public RepositoriFeedBack(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<FeedBack?> Get(int id) => await _appDbContext.TblFeedBack.FirstOrDefaultAsync(f => f.Id == id);

    public async Task<List<FeedBack>> GetAll() => await _appDbContext
        .TblFeedBack
        .OrderByDescending(f => f.Tanggal)
        .OrderByDescending(f => f.SudahDibaca)
        .ToListAsync();

    public async Task<List<FeedBack>> GetAllUnread() => await _appDbContext
        .TblFeedBack
        .Where(f => !f.SudahDibaca)
        .OrderByDescending(f => f.Tanggal)
        .ToListAsync();

    public void Add(FeedBack feedback) => _appDbContext.TblFeedBack.Add(feedback);

    public void Update(FeedBack feedback) => _appDbContext.TblFeedBack.Update(feedback);

    public void Delete(FeedBack feedback) => _appDbContext.TblFeedBack.Remove(feedback);
}
