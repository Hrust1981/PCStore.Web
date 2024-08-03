using PCStore.Web.Core.Data;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public ShoppingCartRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ShoppingCart> CreateAsync(ShoppingCart cart)
        {
            await _dbContext.AddAsync(cart);
            await _dbContext.SaveChangesAsync();
            return cart;
        }

        public async Task<ShoppingCart> GetAsync(Guid id)
        {
            return await _dbContext.ShoppingCarts.FindAsync(id);
        }
    }
}