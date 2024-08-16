using AutoMapper;
using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class ShoppingCartsService(IShoppingCartsRepository shoppingCartRepository, IMapper mapper)
        : IShoppingCartsService
    {
        public async Task<ShoppingCartsEntityDTO> CreateShoppingCartAsync(CreateShoppingCartsEntity createShoppingCart)
        {
            var createdShoppingCart = mapper.Map<ShoppingCart>(createShoppingCart);
            createdShoppingCart.CreatedDate = DateTime.Now;
            await shoppingCartRepository.CreateAsync(createdShoppingCart);
            return mapper.Map<ShoppingCartsEntityDTO>(createdShoppingCart);
        }

        public async Task<ShoppingCartsEntityDTO?> GetShoppingCartByIdAsync(Guid id)
        {
             var shoppingCart = await shoppingCartRepository.GetAsync(id);
             return mapper.Map<ShoppingCartsEntityDTO>(shoppingCart);
        }
    }
}
