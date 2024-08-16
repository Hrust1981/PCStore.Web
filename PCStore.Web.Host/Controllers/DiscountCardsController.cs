using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.DiscountCards;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;

namespace PCStore.Web.Host.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DiscountCardsController(IDiscountCardsService discountCardService) : ControllerBase
    {
        /// <summary>
        /// Receive a discount card by ID
        /// </summary>
        /// <param name="id">Discount card ID</param>
        /// <returns>Discount card</returns>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<DiscountCardsEntityDTO>> GetDiscountCard(Guid id)
        {
            var discountCard = await discountCardService.GetDiscountCardByIdAsync(id);
            if (discountCard == null)
            {
                return NotFound();
            }
            return Ok(discountCard);
        }

        /// <summary>
        /// Create a discount card
        /// </summary>
        /// <param name="createDiscountCard">Entity for creating a discount card</param>
        /// <returns>Discount card</returns>
        /// <response code="200">Ok</response>
        [HttpPost]
        public async Task<ActionResult<DiscountCardsEntityDTO>> CreateDiscountCard([FromBody] CreateDiscountCardsEntity createDiscountCard)
        {
            var discountCard = await discountCardService.CreateDiscountCardAsync(createDiscountCard);
            return Ok(discountCard);
        }
    }
}
