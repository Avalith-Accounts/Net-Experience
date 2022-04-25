using System.ComponentModel.DataAnnotations;
using Core = Net.Experience.Application.UseCases.User.Register;

namespace Net_Experience.UseCases.User.V1.Register
{
    public class RegisterUserRequest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmed { get; set; }
        public string IdentificationDocument { get; set; }

        public Core.RegisterUserRequest ToRequestCore() 
        {
            return new Core.RegisterUserRequest()
            {
                Email = this.Email,
                FirstName = this.FirstName,
                UserName = this.UserName,
                Password = this.Password,
                IdentificationDocument = this.IdentificationDocument,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
