using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess.Repositories
{
    public class ShoppingCartsRepository(ApplicationDbContext dbContext) : IShoppingCartsRepository
    {
        public async Task<ShoppingCart> CreateAsync(ShoppingCart cart)
        {
            await dbContext.AddAsync(cart);
            await dbContext.SaveChangesAsync();
            return cart;
        }

        public async Task<ShoppingCart?> GetAsync(Guid id)
        {
            return await dbContext.ShoppingCarts.FindAsync(id);
        }
    }
}