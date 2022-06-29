using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.User.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdRequest, Response<GetUserByIdResult>>
    {
        private readonly IUserService _userService;

        public GetUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Response<GetUserByIdResult>> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
           var user =  await _userService.GetUserAysnc(request.UserId);

            if(user == null) 
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            return new Response<GetUserByIdResult>(new GetUserByIdResult(user));
        }
    }
}
