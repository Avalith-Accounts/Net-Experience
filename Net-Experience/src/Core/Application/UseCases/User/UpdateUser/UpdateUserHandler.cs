using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.User.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, Response<UpdateUserResult>>
    {
        private readonly IUserService _userService;
        public UpdateUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Response<UpdateUserResult>> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            await ValidateUserExistAsync(request);

            var userResponse = await _userService.UpdateUserAsync(request.ToUserDto());
            
            return new Response<UpdateUserResult>(new UpdateUserResult(userResponse));
        }

        private async Task ValidateUserExistAsync(UpdateUserRequest request)
        {
            var user = await _userService.GetUserAysnc(request.Id);

            if (user is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }
        }
    }
}
