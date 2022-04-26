using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.User.DeleteUserById;
using System;
using System.Threading.Tasks;
using Core = Net.Experience.Application.UseCases.User.DeleteUserById;

namespace Net_Experience.UseCases.User.V1
{
    public partial class UserController
    {
        [HttpDelete]
        [Route("{userId}")]
        [ProducesResponseType(typeof(Core.DeleteUserByIdResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteUserByIdAsync(Guid userId)
        {
            var response = await _mediator.Send(new DeleteUserByIdRequest(userId));

            return Ok(response);
        }
    }
}
