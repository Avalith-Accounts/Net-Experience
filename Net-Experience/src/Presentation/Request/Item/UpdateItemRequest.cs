using System;
using System.ComponentModel.DataAnnotations;
using R = Net.Experience.Application.UseCases.Item.Update;

namespace Net_Experience.Request.Item
{
    public class UpdateItemRequest
    {
        public Guid Id { get; set; }

        [MaxLength(10)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public R.UpdateItemRequest ToUpdateItemRequest()
        {
            return new R.UpdateItemRequest()
            {
                Title = this.Title,
                Description = this.Description,
                Id = this.Id
            };
        }
    }
}
