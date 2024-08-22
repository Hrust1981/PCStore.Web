using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;

namespace PCStore.Web.Host.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ShoppingCartsController(IShoppingCartsService shoppingCartService) : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ShoppingCartsDto>> GetShoppingCart(Guid id)
        {
            var shoppingCart = await shoppingCartService.GetShoppingCartByIdAsync(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return Ok(shoppingCart);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpPost]
        public async Task<ActionResult<ShoppingCartsDto>> CreateShoppingCart([FromBody] CreateShoppingCartsDto createShoppingCart)
        {
            var shoppingCartCreated = await shoppingCartService.CreateShoppingCartAsync(createShoppingCart);
            return Ok(shoppingCartCreated);
        }
    }
}
