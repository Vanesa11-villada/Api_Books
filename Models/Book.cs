using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Author { get; set; }

        public int PublicationYear { get; set; }

        public string? CoverImage { get; set; } // Opcional, por eso es nullable

        public required int UserId { get; set; } // Relación con el usuario

        public User? User { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
    }
}
