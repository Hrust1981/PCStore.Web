using AutoMapper;
using Core.Repositories;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            var createdUser = _mapper.Map<User>(user);
            await _userRepository.CreateAsync(createdUser);
            return createdUser;
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<User> UpdateUserAsync(Guid id, User user)
        {
            var updatableUser = await _userRepository.GetAsync(id);
            //updatableUser = _mapper.Map<User>(user);
            updatableUser.Id = user.Id;
            updatableUser.FirstName = user.FirstName;
            updatableUser.LastName = user.LastName;
            updatableUser.Login = user.Login;
            updatableUser.Email = user.Email;
            updatableUser.PhoneNumber = user.PhoneNumber;
            return await _userRepository.UpdateAsync(updatableUser);
        }
    }
}
