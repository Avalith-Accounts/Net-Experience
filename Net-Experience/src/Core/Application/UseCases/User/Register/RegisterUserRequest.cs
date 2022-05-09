using MediatR;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.User.Register
{
    public class RegisterUserRequest : IRequest<Response<RegisterUserResult>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
