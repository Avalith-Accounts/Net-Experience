using Net.Experience.Domain.Entities;

namespace Net.Experience.Domain.Dtos
{
    public class UserDto
    {
        public UserDto() { }
        public UserDto(User user)
        {
            if(user != null) 
            {
                this.Id = user.Id;
                this.FirstName = user.FirstName;
                this.LastName = user.LastName;
                this.UserName = user.UserName;
                this.Email = user.Email;
                this.PhoneNumber = user.PhoneNumber;
                this.IdentificationDocument = user.IdentificationDocument;
            }
           
        }

        public string Id { get; set; }
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
        public User ToUserChange()
        {
            return new User()
            {
                Id = this.Id,
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
