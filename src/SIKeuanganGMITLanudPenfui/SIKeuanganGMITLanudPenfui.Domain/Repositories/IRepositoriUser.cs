using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriUser
{
    Task<User?> Get(int id);
    Task<User?> GetByUserName(string userName);
    Task<List<User>> GetAll();
    Task<bool> IsUserNameExist(string userName);

    void Add(User user);
    void Delete(User user);
    void Update(User user);
}
