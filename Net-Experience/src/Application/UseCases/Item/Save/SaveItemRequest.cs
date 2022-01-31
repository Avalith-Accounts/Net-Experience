using MediatR;
using Net.Experience.Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Net.Experience.Application.UseCases.Item.Save
{
    public class SaveItemRequest : IRequest<SaveItemResult>
    {
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
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
