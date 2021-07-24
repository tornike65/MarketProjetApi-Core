using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Abstract
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<bool> AddUserAsync(User user);
        Task<User> GetUserByIdAsync(Guid id);
        Task<bool> RemoveUserByIdAsync(Guid id);
        Task<bool> UpdateUserAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
