using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdResult
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DeleteUserByIdResult(Domain.Entities.User user)
        {
            this.UserName = user.UserName;
            this.Email = user.Email;
        }
    }
}
