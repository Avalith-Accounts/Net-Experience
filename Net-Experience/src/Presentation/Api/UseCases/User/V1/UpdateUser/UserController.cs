using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Experience.UseCases.User.V1.UpdateUser;
using System;
using System.Threading.Tasks;
using Core = Net.Experience.Application.UseCases.User.UpdateUser;

namespace Net_Experience.UseCases.User.V1
{
    public partial class UserController
    {
        [HttpPut]
        [Route("{userId}")]
        [ProducesResponseType(typeof(Core.UpdateUserResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUserByIdAsync(Guid userId, UpdateUserRequest updateUserRequest)
        {
            updateUserRequest.Id = userId;
            var response = await _mediator.Send(updateUserRequest.ToUpdateUserRequest());

            return Ok(response);
        }
    }
}
