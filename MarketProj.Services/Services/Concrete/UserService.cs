using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Infrastructure.Helpers;
using MarketProj.Models.Entities;
using MarketProj.Models.Helpers;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using Microsoft.EntityFrameworkCore;
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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository,
            IOptions<AppSettings> options)
        {
            _userRepository = userRepository;
            _appSettings = options.Value;
        }

        public async Task<bool> ChangePasswordAsync(Guid id, string password)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            user.Password = password;
            return await _userRepository.UpdateUserAsync(user);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            var users = await _userRepository.GetAllUsersAsync();
            var user = users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                user.Token = tokenHandler.WriteToken(token);
                return user.WithoutPassword();
            }

            return null;
        }

        public async Task<bool> LogOut()
        {
            var jimi = false;
            await Task.Run(() => jimi = false);
            return jimi;
        }

        public async Task<bool> RegistrationAsync(User user)
        {
            var searchedUser = (await _userRepository.GetAllUsersAsync()).FirstOrDefault(x => x.Username.ToLower() == user.Username.ToLower());
            if (searchedUser != null)
                return false;

            return await _userRepository.AddUserAsync(user);
        }

    }
}
