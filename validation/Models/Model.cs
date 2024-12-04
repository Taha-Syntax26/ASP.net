using System.ComponentModel.DataAnnotations;

namespace validation.Models
{
    public class Model
    {
        [Required(ErrorMessage = "Please enter a valid ID.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please provide an email address.")]
        [EmailAddress(ErrorMessage = "The email address is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Pwd { get; set; }
    }
}
