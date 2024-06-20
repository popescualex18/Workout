using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MinLength(3, ErrorMessage = "The name must be at least 3 characters long.")]
        [MaxLength(255, ErrorMessage = "The name must be less than 255 characters long.")]
        public string Name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "The name must be at least 3 characters long.")]
        [MaxLength(255, ErrorMessage = "The name must be less than 255 characters long.")]
        public string Email { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "The name must be at least 3 characters long.")]
        [MaxLength(255, ErrorMessage = "The name must be less than 255 characters long.")]
        public string Password { get; set; }
    }
}