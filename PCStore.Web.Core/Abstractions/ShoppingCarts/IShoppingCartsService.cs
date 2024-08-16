using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;

namespace PCStore.Web.Core.Abstractions.ShoppingCarts
{
    public interface IShoppingCartsService
    {
        Task<ShoppingCartsEntityDTO?> GetShoppingCartByIdAsync(Guid id);
        Task<ShoppingCartsEntityDTO> CreateShoppingCartAsync(CreateShoppingCartsEntity createShoppingCart);
    }
}
