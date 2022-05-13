using Microsoft.AspNetCore.Identity;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(UserDto userDto);
        Task<User> GetUserAysnc(Guid userId);
        Task DeleteUserAysnc(User user);
        Task<User> UpdateUserAsync(User itemDto);
        Task<User> ProcessUpdateUserAsync(User user, UserDto userDto);
    }
}
