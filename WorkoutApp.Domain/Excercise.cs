using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Domain
{
    public class Excercise
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MinLength(3, ErrorMessage = "The name must be at least 3 characters long.")]
        [MaxLength(255, ErrorMessage = "The name must be less than 255 characters long.")]
        public string Name { get; set; }

        public int Type { get; set; } = 0;
    }
}
