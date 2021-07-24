using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface ITemporaryUserService
    {
        Task AddTemporaryUserAsync(TemporaryUser temporaryUser);
        Task<IEnumerable<TemporaryUser>> GetTemporaryUsersAsync();
        Task<TemporaryUser> Login(string tempUserName,string ip);
        Task RemoveTemporaryUserByIdAsync(Guid Id);

    }
}
