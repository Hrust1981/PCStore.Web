using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(Guid id);
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order> CreateOrderAsync(Order order);
    }
}
