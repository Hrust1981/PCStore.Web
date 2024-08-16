using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;

namespace PCStore.Web.Core.Abstractions.Orders
{
    public interface IOrdersService
    {
        Task<OrdersEntityDTO?> GetOrderByIdAsync(Guid id);
        Task<List<OrdersEntityDTO>> GetAllOrdersAsync();
        Task<OrdersEntityDTO> CreateOrderAsync(CreateOrdersEntity createOrder);
    }
}
