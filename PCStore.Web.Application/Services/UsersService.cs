using AutoMapper;
using PCStore.Web.Core.Abstractions.Users;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class UsersService(IUsersRepository userRepository, IMapper mapper) : IUsersService
    {
        public async Task<UsersDto> CreateUserAsync(CreateUsersDto createUser)
        {
            var user = mapper.Map<User>(createUser);
            user.CreatedDate = DateTime.Now;
            await userRepository.CreateAsync(user);
            return mapper.Map<UsersDto>(user);
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            return await userRepository.DeleteAsync(id);
        }

        public async Task<List<UsersDto>> GetAllUsersAsync()
        {
            var users = await userRepository.GetAllAsync();
            return users.Select(user => mapper.Map<UsersDto>(user)).ToList();
        }

        public async Task<UsersDto?> GetUserByIdAsync(Guid id)
        {
            var user = await userRepository.GetAsync(id);
            return mapper.Map<UsersDto>(user);
        }

        public async Task<UsersDto> UpdateUserAsync(UpdateUsersDto updateUser)
        {
            var updatableUser = await userRepository.GetAsync(updateUser.Id);
            mapper.Map(updateUser, updatableUser);
            updatableUser!.UpdatedDate = DateTime.Now;
            await userRepository.UpdateAsync(updatableUser);
            return mapper.Map<UsersDto>(updatableUser);
        }
    }
}
