using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdHandler : IRequestHandler<DeleteUserByIdRequest, Response<DeleteUserByIdResult>>
    {
        private readonly IUserService _userService;
        public DeleteUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Response<DeleteUserByIdResult>> Handle(DeleteUserByIdRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserAysnc(request.UserId);

             ValidateUserExistAsync(user);

            await _userService.DeleteUserAysnc(user);

            return new Response<DeleteUserByIdResult>(new DeleteUserByIdResult(user));
        }

        private  void ValidateUserExistAsync(Domain.Entities.User user)
        {

            if (user == null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }
        }
    }
}
