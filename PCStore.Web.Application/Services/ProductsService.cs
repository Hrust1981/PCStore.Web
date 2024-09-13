using AutoMapper;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class ProductsService(IProductsRepository productRepository, IMapper mapper) : IProductsService
    {
        public async Task<ProductsDto> CreateProductAsync(CreateProductsDto createProduct)
        {
            var product = mapper.Map<Product>(createProduct);
            product.CreatedDate = DateTime.Now;
            await productRepository.CreateAsync(product);
            return mapper.Map<ProductsDto>(product);
        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            return await productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductsDto>> GetAllProductsAsync()
        {
            var products = await productRepository.GetAllAsync();
            return products.Select(product => mapper.Map<ProductsDto>(product)).ToList();
        }

        public async Task<ProductsDto?> GetProductByIdAsync(Guid id)
        {
            var product = await productRepository.GetAsync(id);
            return mapper.Map<ProductsDto>(product);
        }

        public async Task<ProductsDto> UpdateProductAsync(UpdateProductsDto updateProduct)
        {
            var updatableProduct = await productRepository.GetAsync(updateProduct.Id);
            mapper.Map(updateProduct, updatableProduct);
            updatableProduct!.UpdatedDate = DateTime.Now;
            await productRepository.UpdateAsync(updatableProduct);
            return mapper.Map<ProductsDto>(updatableProduct);
        }
    }
}
