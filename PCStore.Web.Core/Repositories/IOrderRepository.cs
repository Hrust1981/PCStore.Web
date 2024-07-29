using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderByIdAsync(Guid id);
    }
}
