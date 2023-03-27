using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNet_Blog.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Url]
        [DisplayName("Header Image URL")]
        public string? HeaderImageUrl { get; set; }

        [Required]
        [DisplayName("Publish Date")]
        public DateTime CreatedAt { get; set; }
    }
}
