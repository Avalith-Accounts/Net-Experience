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
            Domain.Dtos.UserDto userDto = await ValidateUserExistAsync(request);

            await _userService.DeleteUserAysnc(userDto);

            return new Response<DeleteUserByIdResult>(new DeleteUserByIdResult(userDto));
        }

        private async Task<Domain.Dtos.UserDto> ValidateUserExistAsync(DeleteUserByIdRequest request)
        {
            var userDto = await _userService.GetUserAysnc(request.UserId);

            if (userDto == null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            return userDto;
        }
    }
}
