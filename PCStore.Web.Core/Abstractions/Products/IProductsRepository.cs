using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Abstractions.Products
{
    public interface IProductsRepository
    {
        Task<Product> CreateAsync(Product product);
        Task<Product?> GetAsync(Guid id);
        Task<List<Product>> GetAllAsync();
        Task<Product> UpdateAsync(Product product);
        Task<bool> DeleteAsync(Guid id);
    }
}
