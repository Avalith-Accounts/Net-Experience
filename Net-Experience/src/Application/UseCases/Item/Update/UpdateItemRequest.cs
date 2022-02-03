using MediatR;
using Net.Experience.Domain.Dtos;
using System;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemRequest : IRequest<UpdateItemResult>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemDto ToItemDto()
        {
            return new ItemDto()
            {
                Title = this.Title,
                Description = this.Description,
                Id = this.Id
            };
        }
    }
}
