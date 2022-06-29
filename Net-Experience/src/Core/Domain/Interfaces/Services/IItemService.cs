using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IItemService
    {
        Task<Item> SaveItemAsync(ItemDto itemDto);
        Task<Item> GetItemAsync(Guid itemId);
        Task<Item> UpdateItemAsync(Item item);
        Task<Item> ProcessUpdateItemAsync(Item item, ItemDto itemDto);
    }
}
