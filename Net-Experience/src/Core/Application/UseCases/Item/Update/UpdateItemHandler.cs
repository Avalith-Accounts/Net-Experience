using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Domain.Interfaces.Services;
using Net.Experience.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemRequest, Response<UpdateItemResult>>
    {
        private readonly IItemService _itemService;

        public UpdateItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<Response<UpdateItemResult>> Handle(UpdateItemRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistItemAsync(request);

            var item = await _itemService.UpdateItemAsync(request.ToItemDto());

            var itemResult = new UpdateItemResult(item);

            return new Response<UpdateItemResult>(itemResult);
        }

        private async Task ValidateExistItemAsync(UpdateItemRequest request)
        {
            var itemEntity = await _itemService.GetItemAsync(request.Id);

            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
