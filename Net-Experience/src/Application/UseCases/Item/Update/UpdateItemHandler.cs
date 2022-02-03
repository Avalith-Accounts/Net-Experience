using MediatR;
using Net.Experience.Application.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemRequest, UpdateItemResult>
    {
        private readonly IItemService _itemService;

        public UpdateItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<UpdateItemResult> Handle(UpdateItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _itemService.UpdateItemAsync(request.ToItemDto());

            var itemResult = new UpdateItemResult(item);

            return itemResult;
        }
    }
}
