using Core.Repositories;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task<ShoppingCart> CreateShoppingCartAsync(ShoppingCart cart)
        {
            return await _shoppingCartRepository.CreateAsync(cart);
        }

        public async Task<ShoppingCart> GetShoppingCartByIdAsync(Guid id)
        {
            return await _shoppingCartRepository.GetAsync(id);
        }
    }
}
