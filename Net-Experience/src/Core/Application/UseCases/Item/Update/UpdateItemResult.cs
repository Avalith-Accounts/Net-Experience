using Net.Experience.Domain.Dtos;
using System;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemResult
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public UpdateItemResult(Domain.Entities.Item itemDto)
        {
            Id = itemDto.Id;
            Title = itemDto.Title;
            Description = itemDto.Description;
        }
    }
}
