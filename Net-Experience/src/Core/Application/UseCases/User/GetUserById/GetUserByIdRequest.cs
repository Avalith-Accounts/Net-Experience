using MediatR;
using Net.Experience.Common.Helpers;
using System;

namespace Net.Experience.Application.UseCases.User.GetUserById
{
    public class GetUserByIdRequest : IRequest<Response<GetUserByIdResult>>
    {
        public Guid UserId { get; set; }

        public GetUserByIdRequest(Guid userId)
        {
            UserId = userId;
        }
    }
}
