using AutoMapper;
using PCStore.Web.Core.Models;
using PCStore.Web.Core.Repositories;

namespace PCStore.Web.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            return await _productRepository.CreateAsync(product);
        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _productRepository.GetAsync(id);
        }

        public async Task<Product> UpdateProductAsync(Guid id, Product product)
        {
            var updatableProduct = await _productRepository.GetAsync(id);
            updatableProduct = _mapper.Map<Product>(product);
            return await _productRepository.UpdateAsync(updatableProduct);
        }
    }
}
