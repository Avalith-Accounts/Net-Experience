using MediatR;
using Net.Experience.Common.Helpers;

namespace Net.Experience.Application.UseCases.Authentication.Login
{
    public class LoginRequest : IRequest<Response<LoginResult>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
