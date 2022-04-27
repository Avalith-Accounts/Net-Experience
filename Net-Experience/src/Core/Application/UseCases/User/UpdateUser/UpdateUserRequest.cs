using MediatR;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using System;

namespace Net.Experience.Application.UseCases.User.UpdateUser
{
    public class UpdateUserRequest : IRequest<Response<UpdateUserResult>>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UserDto ToUserDto()
        {
            return new UserDto()
            {
                Id = this.Id.ToString(),
                FirstName = this.FirstName,
                LastName = this.LastName,
                UserName = this.UserName,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
