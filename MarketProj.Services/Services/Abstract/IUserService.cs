using MarketProj.Models.Entities;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface IUserService
    {
        Task<User> LoginAsync(string username, string password);
        Task<bool> RegistrationAsync(User user);
        Task<bool> LogOut();
        Task<bool> ChangePasswordAsync(Guid id, string password);
    }
}
