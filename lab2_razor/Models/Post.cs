using System.ComponentModel.DataAnnotations;

namespace lab2_razor.Pages.Models
{
    public class Post
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [StringLength(1000, MinimumLength = 3)]
        [Required]
        public string? Description { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "You can only use letters.")]
        public string? Author { get; set; }
    }
}
