using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.Item.Update;
using System;
using System.Threading.Tasks;
using UpdateItemRequest = Net_Experience.Request.Item.UpdateItemRequest;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class ItemController
    {
        [HttpPut]
        [Route("{itemId}")]
        [ProducesResponseType(typeof(UpdateItemResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateItemAsync(UpdateItemRequest itemRequest, Guid itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdateItemRequest());
            return Ok(response);
        }
    }
}
