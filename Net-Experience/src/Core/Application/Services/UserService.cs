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
        #region Get by id
        public async Task<UserDto> GetUserAysnc(Guid userId)
        {
            UserDto userDto = null;
            var user = await _userQuery.GetById(userId.ToString());

            if (user != null)
            {
                userDto = new UserDto(user);
            }

            return userDto;
        } 
        #endregion

        #region Register
        public async Task<IdentityResult> RegisterUserAsync(UserDto userDto)
        {
            return await _userManager.CreateAsync(userDto.ToUser(), userDto.Password);
        } 
        #endregion

        #region Delete
        public async Task DeleteUserAysnc(UserDto userDto)
        {
            var user = await _userQuery.GetById(userDto.Id.ToString());
            await _userRepository.Remove(user);
        } 
        #endregion

        #region Update 
        public async Task<UserDto> UpdateUserAsync(UserDto userDto)
        {
            var user = await _userQuery.GetById(userDto.Id.ToString());

            user.Id = userDto.Id;
            user.Email = userDto.Email;
            user.LastName = userDto.LastName;
            user.FirstName = userDto.FirstName;
            user.PasswordHash = userDto.Password;
            user.PhoneNumber = userDto.PhoneNumber;
            user.UserName = userDto.UserName;

            await _userRepository.Update(user);

            return userDto;
        } 
        #endregion
    }
}
