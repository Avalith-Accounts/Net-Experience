using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Net.Experience.Application.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<UserService> _logger;
        public UserService(SignInManager<User> signInManager, 
                           UserManager<User> userManager,
                           ILogger<UserService> logger) 
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }
        public async Task<IdentityResult> RegisterUserAsync(UserDto userDto)
        {

          return await _userManager.CreateAsync(userDto.ToUser(),userDto.Password);
          
        }
    }
}
