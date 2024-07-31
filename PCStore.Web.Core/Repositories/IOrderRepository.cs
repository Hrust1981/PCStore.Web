using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetAsync(Guid id);
        Task<List<Order>> GetAllAsync();
        Task<Order> CreateAsync(Order order);
    }
}
