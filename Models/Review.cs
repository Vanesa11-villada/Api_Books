using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public required string ReviewText { get; set; }

        public required int UserId { get; set; } // Relación con el usuario
        public User? User { get; set; }

        public required int BookId { get; set; } // Relación con el libro
        public Book? Book { get; set; }
    }
}
