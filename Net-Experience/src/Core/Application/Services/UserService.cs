using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Command;
using Net.Experience.Domain.Interfaces.Query;
using Net.Experience.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Application.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<UserService> _logger;
        private readonly IUserQuery _userQuery;
        private readonly IUserRepository _userRepository;
        public UserService(SignInManager<User> signInManager,
                           UserManager<User> userManager,
                           ILogger<UserService> logger,
                           IUserQuery userQuery,
                           IUserRepository userRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _userQuery = userQuery;
            _userRepository = userRepository;
        }
        #region GET
        public async Task<User> GetUserAysnc(Guid userId)
        {
            var user = await _userQuery.GetById(userId.ToString());

            return user;
        } 
        #endregion

        #region REGISTER
        public async Task<IdentityResult> RegisterUserAsync(UserDto userDto)
        {
            return await _userManager.CreateAsync(userDto.ToUser(), userDto.Password);
        } 
        #endregion

        #region DELETE
        public async Task DeleteUserAysnc(User user)
        {
            await _userRepository.Remove(user);
        } 
        #endregion

        #region UPDATE 
        public async Task<User> UpdateUserAsync(User user)
        {
            await _userRepository.Update(user);

            return user;
        }

        public async Task<User> ProcessUpdateUserAsync(User user, UserDto userDto)
        {
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.UserName = userDto.UserName;
            user.Email = userDto.Email;
            user.PhoneNumber = userDto.PhoneNumber;
            user.PasswordHash = userDto.Password;
            user.IdentificationDocument = userDto.IdentificationDocument;

            await UpdateUserAsync(user);
            return user;
    }
        #endregion
    }
}
