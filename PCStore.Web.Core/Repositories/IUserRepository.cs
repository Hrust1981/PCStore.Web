using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);
        Task<User> GetAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(Guid id);
    }
}

