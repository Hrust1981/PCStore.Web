using AutoMapper;
using PCStore.Web.Core.Abstractions.Users;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class UsersService(IUsersRepository userRepository, IMapper mapper) : IUsersService
    {
        public async Task<UsersEntityDTO> CreateUserAsync(CreateUsersEntity createUser)
        {
            var user = mapper.Map<User>(createUser);
            user.CreatedDate = DateTime.Now;
            await userRepository.CreateAsync(user);
            return mapper.Map<UsersEntityDTO>(user);
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var deletableUser = await userRepository.GetAsync(id);
            if (deletableUser == null)
            {
                throw new Exception("User not found");
            }
            return await userRepository.DeleteAsync(id);
        }

        public async Task<List<UsersEntityDTO>> GetAllUsersAsync()
        {
            var users = await userRepository.GetAllAsync();
            ICollection<UsersEntityDTO> usersDto = [];
            foreach (var userDto in users.Select(user => mapper.Map<UsersEntityDTO>(user)))
            {
                usersDto.Add(userDto);
            }
            return usersDto.ToList();
        }

        public async Task<UsersEntityDTO?> GetUserByIdAsync(Guid id)
        {
            var user = await userRepository.GetAsync(id);
            return mapper.Map<UsersEntityDTO>(user);
        }

        public async Task<UsersEntityDTO> UpdateUserAsync(UpdateUsersEntity updateUser)
        {
            var updatableUser = await userRepository.GetAsync(updateUser.Id);
            if (updatableUser == null)
            {
                throw new Exception("User not found");
            }
            mapper.Map(updateUser, updatableUser);
            updatableUser.UpdatedDate = DateTime.Now;
            await userRepository.UpdateAsync(updatableUser);
            return mapper.Map<UsersEntityDTO>(updatableUser);
        }
    }
}
