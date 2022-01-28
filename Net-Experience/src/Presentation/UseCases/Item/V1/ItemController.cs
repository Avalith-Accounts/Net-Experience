using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Item.V1
{
    [ApiController]
    [EnableCors("allowSpecificOrigins")]
    [Route("Item")]
    public partial class ItemController : ControllerBase 
    {
    }
}
