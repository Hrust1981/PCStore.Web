using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.Orders;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;

namespace PCStore.Web.Host.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class OrdersController(IOrdersService orderService) : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpPost]
        public async Task<ActionResult<OrdersDto>> CreateOrder([FromBody] CreateOrdersDto createOrder)
        {
            var createdOrder = await orderService.CreateOrderAsync(createOrder);
            return Ok(createdOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<OrdersDto>> GetOrder(Guid id)
        {
            var order = await orderService.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpGet]
        public async Task<ActionResult<OrdersDto>> GetAllOrders()
        {
            var orders = await orderService.GetAllOrdersAsync();
            return Ok(orders);
        }
    }
}
