using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;

namespace PCStore.Web.Core.Abstractions.Products
{
    public interface IProductsService
    {
        Task<ProductsDto?> GetProductByIdAsync(Guid id);
        Task<List<ProductsDto>> GetAllProductsAsync();
        Task<ProductsDto> CreateProductAsync(CreateProductsDto createProduct);
        Task<ProductsDto> UpdateProductAsync(UpdateProductsDto updateProduct);
        Task<bool> DeleteProductAsync(Guid id);
    }
}
