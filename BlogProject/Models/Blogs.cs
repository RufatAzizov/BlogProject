using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class Blogs
    {
        public int Id { get; set; }
        [MinLength(2), MaxLength(10)]
        public string? Author { get; set; }
        [Required, MinLength(7), MaxLength(64)]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        [Required, MinLength(7), MaxLength(128)]
        public string Text { get; set; }
        public string ImageUrl { get; set; }

    }
}
