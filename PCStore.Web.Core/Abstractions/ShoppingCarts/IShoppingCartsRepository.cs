using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Abstractions.ShoppingCarts
{
    public interface IShoppingCartsRepository
    {
        Task<ShoppingCart?> GetAsync(Guid id);
        Task<ShoppingCart> CreateAsync(ShoppingCart cart);
    }
}
