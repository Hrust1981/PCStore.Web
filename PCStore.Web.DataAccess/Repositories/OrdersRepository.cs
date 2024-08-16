using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Abstractions.Orders;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess.Repositories
{
    public class OrdersRepository(ApplicationDbContext dbContext) : IOrdersRepository
    {
        public async Task<Order> CreateAsync(Order order)
        {
            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await dbContext.Orders.ToListAsync();
        }

        public async Task<Order?> GetAsync(Guid id)
        {
            return await dbContext.Orders.FindAsync(id);
        }
    }
}
