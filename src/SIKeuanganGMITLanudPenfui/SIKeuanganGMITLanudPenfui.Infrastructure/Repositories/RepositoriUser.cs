using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class RepositoriUser : IRepositoriUser
{
    private readonly AppDbContext _appDbContext;

    public RepositoriUser(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<User?> Get(int id) => await _appDbContext.TblUser.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<User?> GetByUserName(string userName) => await _appDbContext.TblUser.FirstOrDefaultAsync(x => x.UserName == userName);

    public async Task<List<User>> GetAll() => await _appDbContext.TblUser.ToListAsync();

    public async Task<bool> IsUserNameExist(string userName) => await _appDbContext.TblUser.AnyAsync(x => x.UserName == userName);

    public void Add(User user) => _appDbContext.TblUser.Add(user);

    public void Delete(User user) => _appDbContext.TblUser.Remove(user);

    public void Update(User user) => _appDbContext.TblUser.Update(user);
}
