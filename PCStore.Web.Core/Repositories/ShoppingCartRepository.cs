using PCStore.Web.Core.Data;
using PCStore.Web.Core.Models;

namespace Core.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public ShoppingCartRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ShoppingCart> GetCartByIdAsync(Guid id)
        {
            return await _dbContext.ShoppingCarts.FindAsync(id);
        }
    }
}