using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core = Net.Experience.Application.UseCases.User.Register;
using Net_Experience.UseCases.User.V1.Register;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.User.V1
{
    public partial class UserController
    {
        [HttpPost]
        [Route("Registers")]
        [ProducesResponseType(typeof(Core.RegisterUserResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> registerUserAsync(RegisterUserRequest registerUserRequest)
        {
            var response = await _mediator.Send(registerUserRequest.ToRequestCore());

            return Ok(response);
        }
    }
}
