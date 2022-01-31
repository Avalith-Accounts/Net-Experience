using MediatR;
using Net.Experience.Application.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Item.GetById
{
    public class GetItemHandler : IRequestHandler<GetItemRequest, GetItemResult>
    {
        private readonly IItemService _itemService;

        public GetItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<GetItemResult> Handle(GetItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _itemService.GetItemAsync(request.Id);

            var itemResult = new GetItemResult(item);

            return itemResult;
        }
    }
}
