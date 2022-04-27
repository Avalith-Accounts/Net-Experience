using Microsoft.AspNetCore.Identity;
using Net.Experience.Domain.Dtos;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(UserDto userDto);
        Task<UserDto> GetUserAysnc(Guid userId);
        Task DeleteUserAysnc(UserDto user);
        Task<UserDto> UpdateUserAsync(UserDto itemDto);
    }
}
