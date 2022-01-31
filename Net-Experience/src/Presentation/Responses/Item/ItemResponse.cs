using System;

namespace Net_Experience.Responses.Item
{
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemResponse(Guid id,string title, string description) 
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
