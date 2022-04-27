using System;
using R = Net.Experience.Application.UseCases.User.UpdateUser;

namespace Net_Experience.UseCases.User.V1.UpdateUser
{
    public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public R.UpdateUserRequest ToUpdateUserRequest() 
        {
            return new R.UpdateUserRequest()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                UserName = this.UserName,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
