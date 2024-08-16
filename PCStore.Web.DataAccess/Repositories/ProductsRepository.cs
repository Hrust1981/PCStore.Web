using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess.Repositories
{
    public class ProductsRepository(ApplicationDbContext dBContext) : IProductsRepository
    {
        public async Task<Product> CreateAsync(Product product)
        {
            await dBContext.Products.AddAsync(product);
            await dBContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var product = await GetAsync(id);
            if (product == null)
            {
                return false;
            }
            dBContext.Products.Remove(product);
            await dBContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await dBContext.Products.ToListAsync();
        }

        public async Task<Product?> GetAsync(Guid id)
        {
            return await dBContext.Products.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            dBContext.Products.Update(product);
            await dBContext.SaveChangesAsync();
            return product;
        }
    }
}
