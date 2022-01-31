using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Item.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Items")]
    public partial class ItemController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
