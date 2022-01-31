using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Experience.Request.Item;
using Net_Experience.Responses;
using Net_Experience.Responses.Item;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class ItemController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(ItemResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveItemAsync(SaveItemRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSaveItemRequest());
            return Ok(new ItemResponse(response.Id,response.Title,response.Description));
        }
    }
}
