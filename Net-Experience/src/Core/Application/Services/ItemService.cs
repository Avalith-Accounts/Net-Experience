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

        #region SAVE
        public async Task<Item> SaveItemAsync(ItemDto itemDto)
        {
            var item = await _itemRepository.Add(itemDto.ToItemEntity());

            return item;
        }
        #endregion

        #region GET
        public async Task<Item> GetItemAsync(Guid itemId)
        {
            var item = await _itemQuery.GetById(itemId);

            return item;
        } 
        #endregion

        #region UPDATE
        public async Task<Item> UpdateItemAsync(Item item)
        {

            await _itemRepository.Update(item);

            return item;
        }
        #endregion

        #region PROCESS UPDATE
        public async Task<Item> ProcessUpdateItemAsync(Item item, ItemDto itemDto)
        {
            item.Description = itemDto.Description;
            item.Title = item.Title;

            await UpdateItemAsync(item);

            return item;
        } 
        #endregion
    }
}
