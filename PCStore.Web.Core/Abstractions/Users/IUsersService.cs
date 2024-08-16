using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;

namespace PCStore.Web.Core.Abstractions.Users
{
    public interface IUsersService
    {
        Task<UsersEntityDTO?> GetUserByIdAsync(Guid id);
        Task<List<UsersEntityDTO>> GetAllUsersAsync();
        Task<UsersEntityDTO> CreateUserAsync(CreateUsersEntity createUser);
        Task<UsersEntityDTO> UpdateUserAsync(UpdateUsersEntity updateUser);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
