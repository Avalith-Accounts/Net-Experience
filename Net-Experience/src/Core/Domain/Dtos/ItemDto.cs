using Net.Experience.Domain.Entities;
using System;

namespace Net.Experience.Domain.Dtos
{
    public class ItemDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemDto() { }

        public ItemDto(Guid id, string title,string description) 
        {
            Id = id;
            Title = title;
            Description = description;
        }
        public Item ToItemEntity() 
        {
            return new Item()
            {
                Despription = this.Description,
                Title = this.Title
            };
        }
    }
}
