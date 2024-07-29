using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Data
{
    public class ApplicationDBContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DiscountCard> Discounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
