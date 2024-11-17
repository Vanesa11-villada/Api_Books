using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public required int RantingValue { get; set; }

        public required int UserId { get; set; }
        public User? User { get; set; }

        public required int BookId { get; set; }
        public Book? Book { get; set; }
    }
}