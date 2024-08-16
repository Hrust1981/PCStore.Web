﻿using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;

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
        public async Task<ActionResult<ShoppingCartsEntityDTO>> GetShoppingCart(Guid id)
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
        public async Task<ActionResult<ShoppingCartsEntityDTO>> CreateShoppingCart([FromBody] CreateShoppingCartsEntity createShoppingCart)
        {
            var shoppingCartCreated = await shoppingCartService.CreateShoppingCartAsync(createShoppingCart);
            return Ok(shoppingCartCreated);
        }
    }
}
