using Net.Experience.Domain.Interfaces.Services;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Command;
using Net.Experience.Domain.Interfaces.Query;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IItemQuery _itemQuery;
        public ItemService(IItemRepository itemRepository, IItemQuery itemQuery) 
        {
            _itemRepository = itemRepository;
            _itemQuery = itemQuery;
        }
     
        public async Task<ItemDto> SaveItemAsync(ItemDto itemDto)
        {
            var item = await _itemRepository.Add(itemDto.ToItemEntity());
           
            itemDto.Id = item.Id;

            return itemDto;
        }
        public async Task<ItemDto> GetItemAsync(Guid itemId)
        {
            ItemDto itemDto = null;
            var item = await _itemQuery.GetById(itemId);

            if(item != null) 
            {
                itemDto = new ItemDto(item.Id, item.Title, item.Despription);
            }

            return itemDto;
        }

        public async Task<ItemDto> UpdateItemAsync(ItemDto itemDto)
        {
            Item item = new Item();

            item.Id = itemDto.Id;
            item.Title = itemDto.Title;
            item.Despription = item.Despription;

            await _itemRepository.Update(item);
            
            return itemDto;
        }
    }
}
