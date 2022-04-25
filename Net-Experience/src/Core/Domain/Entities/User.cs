using Microsoft.AspNetCore.Identity;

namespace Net.Experience.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
