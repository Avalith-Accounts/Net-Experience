using Microsoft.AspNetCore.Identity;
using Net.Experience.Domain.Dtos;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(UserDto userDto);
    }
}
