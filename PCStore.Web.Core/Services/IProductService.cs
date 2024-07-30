using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Services
{
    public interface IProductService
    {
        Task<Product> GetProductByIdAsync(Guid id);
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Guid id, Product product);
        Task<bool> DeleteProductAsync(Guid id);
    }
}
