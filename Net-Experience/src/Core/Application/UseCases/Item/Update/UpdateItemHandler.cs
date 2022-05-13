using MediatR;
using Net.Experience.Application.Exceptions;
using Net.Experience.Domain.Interfaces.Services;
using Net.Experience.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemRequest, Response<UpdateItemResult>>
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;
        public UpdateItemHandler(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }
        public async Task<Response<UpdateItemResult>> Handle(UpdateItemRequest request, CancellationToken cancellationToken)
        {
            var itemEntity = await _itemService.GetItemAsync(request.Id);

            ValidateExistItemAsync(itemEntity);

            var item = await _itemService.ProcessUpdateItemAsync(itemEntity,_mapper.Map<ItemDto>(request));

            var itemResult = new UpdateItemResult(item);

            return new Response<UpdateItemResult>(itemResult);
        }

        private void ValidateExistItemAsync(Domain.Entities.Item itemEntity)
        {
            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
