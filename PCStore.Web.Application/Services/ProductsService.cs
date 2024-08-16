using AutoMapper;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class ProductsService(IProductsRepository productRepository, IMapper mapper) : IProductsService
    {
        public async Task<ProductsEntityDTO> CreateProductAsync(CreateProductsEntity createProduct)
        {
            var product = mapper.Map<Product>(createProduct);
            product.CreatedDate = DateTime.Now;
            await productRepository.CreateAsync(product);
            return mapper.Map<ProductsEntityDTO>(product);
        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            var deletableProduct = await productRepository.GetAsync(id);
            if (deletableProduct == null)
            {
                throw new Exception("Product not found");
            }
            return await productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductsEntityDTO>> GetAllProductsAsync()
        {
            var products = await productRepository.GetAllAsync();
            ICollection<ProductsEntityDTO> productsDto = [];
            foreach (var productDto in products.Select(product => mapper.Map<ProductsEntityDTO>(product)))
            {
                productsDto.Add(productDto);
            }
            return productsDto.ToList();
        }

        public async Task<ProductsEntityDTO?> GetProductByIdAsync(Guid id)
        {
            var product = await productRepository.GetAsync(id);
            return mapper.Map<ProductsEntityDTO>(product);
        }

        public async Task<ProductsEntityDTO> UpdateProductAsync(UpdateProductsEntity updateProduct)
        {
            var updatableProduct = await productRepository.GetAsync(updateProduct.Id);
            if (updatableProduct == null)
            {
                throw new Exception("Product not found");
            }
            mapper.Map(updateProduct, updatableProduct);
            updatableProduct.UpdatedDate = DateTime.Now;
            await productRepository.UpdateAsync(updatableProduct);
            return mapper.Map<ProductsEntityDTO>(updatableProduct);
        }
    }
}
