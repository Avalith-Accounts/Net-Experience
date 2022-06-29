using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.User.GetUserById
{
    public class GetUserByIdResult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string IdentificationDocument { get; set; }

        public GetUserByIdResult(Domain.Entities.User user) 
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.UserName = user.UserName;
            this.Email = user.Email;
            this.PhoneNumber = user.PhoneNumber;
            this.IdentificationDocument = user.IdentificationDocument;
        }
    }
}
