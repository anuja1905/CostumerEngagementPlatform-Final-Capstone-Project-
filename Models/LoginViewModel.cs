using System.ComponentModel.DataAnnotations;

namespace CustomerEngagementPlatform.Models
{
    // This model is used only for the login form
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string? Role { get; set; }
    }
}