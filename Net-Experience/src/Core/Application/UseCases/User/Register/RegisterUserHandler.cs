using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Interfaces.Services;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.User.Register
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserRequest, Response<RegisterUserResult>>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public RegisterUserHandler(IUserService userService, IMapper mapper) 
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<Response<RegisterUserResult>> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            var result = await _userService.RegisterUserAsync(_mapper.Map<UserDto>(request));
            
            if (result.Errors.Any()) 
            {
                throw new BusinessRulesException(MessageGeneral.BussinessRules, result.Errors.Select(x => x.Description));
            }

            return new Response<RegisterUserResult>(new RegisterUserResult(request.UserName,request.Email));
        }
    }
}
