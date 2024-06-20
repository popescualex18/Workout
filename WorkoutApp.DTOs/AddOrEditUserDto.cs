using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.DTOs
{
    public class AddOrEditUserDto : UserDto
    {
        [Required(ErrorMessage = "Confirmation password is required")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmationPassword { get; set; }
    }
}
