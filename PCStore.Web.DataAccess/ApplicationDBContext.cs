using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : DbContext(options)
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DiscountCard> Discounts { get; set; }
    }
}
