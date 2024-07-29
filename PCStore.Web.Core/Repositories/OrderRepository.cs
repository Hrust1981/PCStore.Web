using PCStore.Web.Core.Data;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public OrderRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> GetOrderByIdAsync(Guid id)
        {
            return await _dbContext.Orders.FindAsync(id);
        }
    }
}
