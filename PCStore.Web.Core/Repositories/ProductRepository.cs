using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Data;
using PCStore.Web.Core.Models;
using PCStore.Web.Core.Repositories;

namespace Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _dBContext;

        public ProductRepository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _dBContext.Products.AddAsync(product);
            await _dBContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var product = await GetAsync(id);
            _dBContext.Products.Remove(product);
            await _dBContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _dBContext.Products.ToListAsync();
        }

        public async Task<Product> GetAsync(Guid id)
        {
            return await _dBContext.Products.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _dBContext.Products.Update(product);
            await _dBContext.SaveChangesAsync();
            return product;
        }
    }
}
