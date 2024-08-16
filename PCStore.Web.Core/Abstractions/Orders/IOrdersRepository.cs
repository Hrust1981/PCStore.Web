using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Abstractions.Orders
{
    public interface IOrdersRepository
    {
        Task<Order?> GetAsync(Guid id);
        Task<List<Order>> GetAllAsync();
        Task<Order> CreateAsync(Order order);
    }
}
