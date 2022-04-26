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

        public GetUserByIdResult(UserDto userDto) 
        {
            this.FirstName = userDto.FirstName;
            this.LastName = userDto.LastName;
            this.UserName = userDto.UserName;
            this.Email = userDto.Email;
            this.PhoneNumber = userDto.PhoneNumber;
            this.IdentificationDocument = userDto.IdentificationDocument;
        }
    }
}
