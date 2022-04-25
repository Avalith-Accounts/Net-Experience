using Net.Experience.Domain.Entities;

namespace Net.Experience.Domain.Dtos
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string IdentificationDocument { get; set; }

        public User ToUser() 
        {
            return new User()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                UserName = this.UserName,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                PasswordHash = this.Password,
                IdentificationDocument = this.IdentificationDocument
            };
        }
    }
}
