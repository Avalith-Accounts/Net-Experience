using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Application.Interfaces.Services;
using Net.Experience.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Item.GetById
{
    public class GetItemHandler : IRequestHandler<GetItemRequest, Response<GetItemResult>>
    {
        private readonly IItemService _itemService;

        public GetItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<Response<GetItemResult>> Handle(GetItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _itemService.GetItemAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetItemResult(item);

            return new Response<GetItemResult>(itemResult);
        }
    }
}
