using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core.Abstractions.Users;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess.Repositories
{
    public class UsersRepository(ApplicationDbContext dbContext) : IUsersRepository
    {
        public async Task<User> CreateAsync(User user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var user = await GetAsync(id);
            dbContext.Users.Remove(user!);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetAsync(Guid id)
        {
            return await dbContext.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
    }
}
