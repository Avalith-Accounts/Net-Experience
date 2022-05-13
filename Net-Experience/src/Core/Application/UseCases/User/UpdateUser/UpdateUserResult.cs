using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.User.UpdateUser
{
    public class UpdateUserResult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UpdateUserResult(Domain.Entities.User user) 
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
        }
    }
}
