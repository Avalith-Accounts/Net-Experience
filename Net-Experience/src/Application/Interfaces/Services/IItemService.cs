using Net.Experience.Domain.Dtos;
using System;
using System.Threading.Tasks;

namespace Net.Experience.Application.Interfaces.Services
{
    public interface IItemService
    {
        Task<ItemDto> SaveItemAsync(ItemDto itemDto);
        Task<ItemDto> GetItemAsync(Guid itemId);
    }
}
