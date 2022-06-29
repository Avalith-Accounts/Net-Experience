using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Experience.UseCases.Authentication.V1.Login;
using System.Threading.Tasks;
using Core = Net.Experience.Application.UseCases.Authentication.Login;

namespace Net_Experience.UseCases.Authentication.V1
{
    public partial class AuthenticationController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(Core.LoginResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> LoginAsync(LoginRequest loginRequest)
        {
          
            //var response = await _mediator.Send(updateUserRequest.ToUpdateUserRequest());

            return Ok();
        }
    }
}
