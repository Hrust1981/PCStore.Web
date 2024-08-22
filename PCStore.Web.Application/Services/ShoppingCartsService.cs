using AutoMapper;
using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class ShoppingCartsService(IShoppingCartsRepository shoppingCartRepository, IMapper mapper)
        : IShoppingCartsService
    {
        public async Task<ShoppingCartsDto> CreateShoppingCartAsync(CreateShoppingCartsDto createShoppingCart)
        {
            var createdShoppingCart = mapper.Map<ShoppingCart>(createShoppingCart);
            createdShoppingCart.CreatedDate = DateTime.Now;
            await shoppingCartRepository.CreateAsync(createdShoppingCart);
            return mapper.Map<ShoppingCartsDto>(createdShoppingCart);
        }

        public async Task<ShoppingCartsDto?> GetShoppingCartByIdAsync(Guid id)
        {
             var shoppingCart = await shoppingCartRepository.GetAsync(id);
             return mapper.Map<ShoppingCartsDto>(shoppingCart);
        }
    }
}
