using MediatR;
using Net.Experience.Domain.Interfaces.Services;
using Net.Experience.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.Item.Save
{
    public class SaveItemHandler : IRequestHandler<SaveItemRequest, Response<SaveItemResult>>
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public SaveItemHandler(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }
        public async Task<Response<SaveItemResult>> Handle(SaveItemRequest request, CancellationToken cancellationToken)
        {
           var item = await _itemService.SaveItemAsync(_mapper.Map<ItemDto>(request));

            var itemResult = new SaveItemResult(item);

            return new Response<SaveItemResult>(itemResult);
        }
    }
}
