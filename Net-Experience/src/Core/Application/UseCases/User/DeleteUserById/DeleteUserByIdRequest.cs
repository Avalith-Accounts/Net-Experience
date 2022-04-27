using MediatR;
using Net.Experience.Common.Helpers;
using System;

namespace Net.Experience.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdRequest : IRequest<Response<DeleteUserByIdResult>>
    {
        public Guid UserId { get; set; }

        public DeleteUserByIdRequest(Guid userId)
        {
            UserId = userId;
        }
    }
}
