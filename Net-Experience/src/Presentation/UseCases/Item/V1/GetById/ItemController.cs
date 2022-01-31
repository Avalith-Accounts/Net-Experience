using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.Item.GetById;
using Net.Experience.Application.UseCases.Item.Save;
using Net_Experience.Responses;
using Net_Experience.Responses.Item;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class ItemController
    {
        [HttpGet]
        [Route("{itemId}")]
        [ProducesResponseType(typeof(ItemResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetItemAsync(Guid itemId)
        {
            var response = await _mediator.Send(new GetItemRequest(itemId));
            return Ok(new ItemResponse(response.Id,response.Title,response.Description));
        }
    }
}
