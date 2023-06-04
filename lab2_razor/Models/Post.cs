using System.ComponentModel.DataAnnotations;

namespace lab2_razor.Pages.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        [DataType(DataType.Date)]
        public string? PublicDate { get; set; }
    }
}
