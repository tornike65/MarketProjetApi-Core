using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Models.Entities;
using MarketProj.Services.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Concrete
{
    public class AdminService : IAdminService
    {
        readonly private IUserRepository _userRepository;

        public AdminService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<bool> RemoveUserAsync(Guid id)
        {
            return await _userRepository.RemoveUserByIdAsync(id);
        }

        public async Task<bool> UpdateUserAsync(User user, Guid id)
        {
            user.Id = id;
            return await _userRepository.UpdateUserAsync(user);
        }
    }
}
