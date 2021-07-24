using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Concrete
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly UsersDB _usersDB;
        public UserRepository(UsersDB usersDB) : base(usersDB)
        {
            _usersDB = usersDB;
        }

       
        public async Task<bool> AddUserAsync(User user)
        {
            if (user == null)
                return false;

            await AddAsync(user);
            return true;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<bool> RemoveUserByIdAsync(Guid id)
        {
            if (await GetByIdAsync(id) == null)
                return false;

            await DeleteAsync(id);
            return true;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            if (user?.Id == default)
                return false;

            await UpdateAsync(user);
            return true;
        }
    }
}
