using AutoMapper;
using PCStore.Web.Core.Abstractions.Orders;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class OrdersService(IOrdersRepository orderRepository, IMapper mapper) : IOrdersService
    {
        public async Task<OrdersDto> CreateOrderAsync(CreateOrdersDto createOrder)
        {
            var order = mapper.Map<Order>(createOrder);
            order.CreatedDate = DateTime.Now;
            await orderRepository.CreateAsync(order);
            return mapper.Map<OrdersDto>(order);
        }

        public async Task<List<OrdersDto>> GetAllOrdersAsync()
        {
            var orders = await orderRepository.GetAllAsync();
            ICollection<OrdersDto> ordersDto = [];
            foreach (var orderDto in orders.Select(order => mapper.Map<OrdersDto>(order)))
            {
                ordersDto.Add(orderDto);
            }
            return ordersDto.ToList();
        }

        public async Task<OrdersDto?> GetOrderByIdAsync(Guid id)
        {
            var order = await orderRepository.GetAsync(id);
            return mapper.Map<OrdersDto>(order);
        }
    }
}
