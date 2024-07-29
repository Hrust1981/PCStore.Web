using PCStore.Web.Core.Models;

namespace Core.Repositories
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> GetCartByIdAsync(Guid id);
    }
}
