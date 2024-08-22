using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;

namespace PCStore.Web.Core.Abstractions.Users
{
    public interface IUsersService
    {
        Task<UsersDto?> GetUserByIdAsync(Guid id);
        Task<List<UsersDto>> GetAllUsersAsync();
        Task<UsersDto> CreateUserAsync(CreateUsersDto createUser);
        Task<UsersDto> UpdateUserAsync(UpdateUsersDto updateUser);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
