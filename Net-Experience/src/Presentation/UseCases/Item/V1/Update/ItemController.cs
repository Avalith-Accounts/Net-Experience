using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Experience.Request.Item;
using Net_Experience.Responses.Item;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class ItemController
    {
        [HttpPut]
        [Route("{itemId}")]
        [ProducesResponseType(typeof(ItemResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateItemAsync(UpdateItemRequest itemRequest, Guid itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdateItemRequest());
            return Ok(new ItemResponse(response.Id, response.Title, response.Description));
        }
    }
}
