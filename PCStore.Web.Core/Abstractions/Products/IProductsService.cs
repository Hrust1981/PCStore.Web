using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;

namespace PCStore.Web.Core.Abstractions.Products
{
    public interface IProductsService
    {
        Task<ProductsEntityDTO?> GetProductByIdAsync(Guid id);
        Task<List<ProductsEntityDTO>> GetAllProductsAsync();
        Task<ProductsEntityDTO> CreateProductAsync(CreateProductsEntity createProduct);
        Task<ProductsEntityDTO> UpdateProductAsync(UpdateProductsEntity updateProduct);
        Task<bool> DeleteProductAsync(Guid id);
    }
}
