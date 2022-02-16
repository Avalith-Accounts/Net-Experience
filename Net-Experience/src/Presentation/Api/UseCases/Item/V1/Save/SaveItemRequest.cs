using System.ComponentModel.DataAnnotations;
using R = Net.Experience.Application.UseCases.Item.Save;

namespace Net_Experience.UseCases.Item.V1
{
    public class SaveItemRequest
    {
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public R.SaveItemRequest ToSaveItemRequest()
        {
            return new R.SaveItemRequest()
            {
                Title = this.Title,
                Description = this.Description
            };
        }
    }
}
