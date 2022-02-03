using MediatR;
using Net.Experience.Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Net.Experience.Application.UseCases.Item.Save
{
    public class SaveItemRequest : IRequest<SaveItemResult>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemDto ToItemDto() 
        {
            return new ItemDto()
            {
                Title = this.Title,
                Description = this.Description
            };       
        }
    }
}
