using System.ComponentModel.DataAnnotations;

namespace Interview.Entities.Models
{
    public class Book
    {

        [Key]
        public Guid BookId { get; set; }

        [Required(ErrorMessage = "Book Title can not be blank")]
        public string BookName { get; set; }
        public string? Description { get; set; }
        public int Pages { get; set; }
        [Required]
        public string CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public bool Favorite { get; set; }
    }
}