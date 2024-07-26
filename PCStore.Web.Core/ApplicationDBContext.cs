using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Entities;

namespace PCStore.Web.Core
{
    public class ApplicationDBContext : DbContext
    {
        protected ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
