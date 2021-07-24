using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Infrastructure.Helpers;
using MarketProj.Models.Constants;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Concrete
{
    public class TemporaryUserService : ITemporaryUserService
    {
        private readonly ITemporaryUserRepository _temporaryUserRepository;
        private readonly AppSettings _appSettings;
        public TemporaryUserService(ITemporaryUserRepository temporaryUserRepository, IOptions<AppSettings> options)
        {
            _temporaryUserRepository = temporaryUserRepository;
            _appSettings = options.Value;

        }

        public async Task AddTemporaryUserAsync(TemporaryUser temporaryUser)
        {
            await _temporaryUserRepository.AddAsync(temporaryUser);
        }

        public async Task<IEnumerable<TemporaryUser>> GetTemporaryUsersAsync()
        {
            return await _temporaryUserRepository.Query();
        }

        public async Task<TemporaryUser> Login(string tempUserName, string ip)
        {
            var users = await _temporaryUserRepository.Query();
            var currentUser = users.FirstOrDefault(x => x.Username == tempUserName && x.UserIP == ip);
            var isNew = false;


            if (currentUser == null)
            {
                isNew = true;
                currentUser = new TemporaryUser(tempUserName, Role.TempCustomer);
                currentUser.SetIP(ip);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, currentUser.Id.ToString()),
                    new Claim(ClaimTypes.Role, currentUser.Role),
                    new Claim(ClaimTypes.NameIdentifier, currentUser.Username),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            currentUser.SetToken(tokenHandler.WriteToken(token));

            if (isNew)
            {
                await _temporaryUserRepository.AddAsync(currentUser);
            }

            return currentUser;

        }

        public async Task RemoveTemporaryUserByIdAsync(Guid Id)
        {
            await _temporaryUserRepository.DeleteAsync(Id);
        }
    }
}
