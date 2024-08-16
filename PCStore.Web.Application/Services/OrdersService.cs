using AutoMapper;
using PCStore.Web.Core.Abstractions.Orders;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class OrdersService(IOrdersRepository orderRepository, IMapper mapper) : IOrdersService
    {
        public async Task<OrdersEntityDTO> CreateOrderAsync(CreateOrdersEntity createOrder)
        {
            var order = mapper.Map<Order>(createOrder);
            order.CreatedDate = DateTime.Now;
            await orderRepository.CreateAsync(order);
            return mapper.Map<OrdersEntityDTO>(order);
        }

        public async Task<List<OrdersEntityDTO>> GetAllOrdersAsync()
        {
            var orders = await orderRepository.GetAllAsync();
            ICollection<OrdersEntityDTO> ordersDto = [];
            foreach (var orderDto in orders.Select(order => mapper.Map<OrdersEntityDTO>(order)))
            {
                ordersDto.Add(orderDto);
            }
            return ordersDto.ToList();
        }

        public async Task<OrdersEntityDTO?> GetOrderByIdAsync(Guid id)
        {
            var order = await orderRepository.GetAsync(id);
            return mapper.Map<OrdersEntityDTO>(order);
        }
    }
}
