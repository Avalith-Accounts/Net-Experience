using AutoMapper;
using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;
using E = Net.Experience.Domain.Entities;

namespace Net.Experience.Application.UseCases.User.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, Response<UpdateUserResult>>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UpdateUserHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<Response<UpdateUserResult>> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserAysnc(request.Id);

            ValidateUserExistAsync(user);

            var userResponse = await _userService.ProcessUpdateUserAsync(user,_mapper.Map<UserDto>(request));
            
            return new Response<UpdateUserResult>(new UpdateUserResult(userResponse));
        }

        private void ValidateUserExistAsync(E.User user)
        {
            if (user is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }
        }
    }
}
