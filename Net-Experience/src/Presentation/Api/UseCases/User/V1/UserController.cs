using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.User.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Users")]
    public partial class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
