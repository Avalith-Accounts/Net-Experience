using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.User.GetUserById;
using System;
using System.Threading.Tasks;
using Core = Net.Experience.Application.UseCases.User.GetUserById;

namespace Net_Experience.UseCases.User.V1
{
    public partial class UserController
    {
        [HttpGet]
        [Route("{userId}")]
        [ProducesResponseType(typeof(Core.GetUserByIdResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUserByIdAsync(Guid userId)
        {
            var response = await _mediator.Send(new GetUserByIdRequest(userId));

            return Ok(response);
        }
    }
}
