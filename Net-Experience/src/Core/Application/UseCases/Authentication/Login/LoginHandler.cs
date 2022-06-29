using MediatR;
using Net.Experience.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Authentication.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, Response<LoginResult>>
    {
        public Task<Response<LoginResult>> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = 0;
            throw new System.NotImplementedException();

        }
    }
}
