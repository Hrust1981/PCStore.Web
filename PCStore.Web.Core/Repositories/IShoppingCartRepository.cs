using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> GetAsync(Guid id);
        Task<ShoppingCart> CreateAsync(ShoppingCart cart);
    }
}
