using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Services
{
    public interface IShoppingCartService
    {
        Task<ShoppingCart> GetShoppingCartByIdAsync(Guid id);
        Task<ShoppingCart> CreateShoppingCartAsync(ShoppingCart cart);
    }
}
