using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Repositories;

public interface IRepositoriFeedBack
{
    Task<FeedBack?> Get(int id);
    Task<List<FeedBack>> GetAll();
    Task<List<FeedBack>> GetAllUnread();

    void Add(FeedBack feedback);
    void Update(FeedBack feedback);
    void Delete(FeedBack feedback);
}