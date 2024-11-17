using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }

        // Inicializa la colección en el constructor
        public User()
        {
            Books = new List<Book>();
        }

        public ICollection<Book> Books { get; set; }
    }
}
