using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.User.Register
{
    public class RegisterUserResult
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public RegisterUserResult(string userName,string email)
        {
            UserName = userName;
            Email = email;
        }
    }
}
