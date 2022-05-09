using AutoMapper;
using Net.Experience.Application.UseCases.Item.Save;
using Net.Experience.Application.UseCases.Item.Update;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.AutoMapper
{
    public class AutoMappingItem : Profile
    {
        public AutoMappingItem() 
        {
            CreateMap<SaveItemRequest, ItemDto>();
            CreateMap<UpdateItemRequest, ItemDto>();
        }
    }
}
