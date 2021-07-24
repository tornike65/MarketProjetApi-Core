using MarketProj.Models.Entities;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<bool> RemoveUserAsync(Guid id);
        Task<bool> UpdateUserAsync(User user, Guid id);
    }
}
