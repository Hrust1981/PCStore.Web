using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;

namespace PCStore.Web.Core.Abstractions.ShoppingCarts
{
    public interface IShoppingCartsService
    {
        Task<ShoppingCartsDto?> GetShoppingCartByIdAsync(Guid id);
        Task<ShoppingCartsDto> CreateShoppingCartAsync(CreateShoppingCartsDto createShoppingCart);
    }
}
