using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;

namespace PCStore.Web.Core.Abstractions.Orders
{
    public interface IOrdersService
    {
        Task<OrdersDto?> GetOrderByIdAsync(Guid id);
        Task<List<OrdersDto>> GetAllOrdersAsync();
        Task<OrdersDto> CreateOrderAsync(CreateOrdersDto createOrder);
    }
}
