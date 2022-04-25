using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Interfaces.Services;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.User.Register
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserRequest, Response<RegisterUserResult>>
    {
        private readonly IUserService _userService;

        public RegisterUserHandler(IUserService userService) 
        {
            _userService = userService;
        }
        public async Task<Response<RegisterUserResult>> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            var userDto = request.ToUserDto();
            var result = await _userService.RegisterUserAsync(userDto);

            if (result.Errors.Any()) 
            {
                throw new BusinessRulesException(MessageGeneral.BussinessRules, result.Errors.Select(x => x.Description));
            }

            return new Response<RegisterUserResult>(new RegisterUserResult(userDto));
        }
    }
}
