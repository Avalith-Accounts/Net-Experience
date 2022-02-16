using Net.Experience.Domain.Dtos;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IItemService
    {
        Task<ItemDto> SaveItemAsync(ItemDto itemDto);
        Task<ItemDto> GetItemAsync(Guid itemId);
        Task<ItemDto> UpdateItemAsync(ItemDto itemDto);
    }
}
