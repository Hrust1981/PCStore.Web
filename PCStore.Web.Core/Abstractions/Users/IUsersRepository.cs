using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Abstractions.Users
{
    public interface IUsersRepository
    {
        Task<User> CreateAsync(User user);
        Task<User?> GetAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(Guid id);
    }
}

