using System.ComponentModel.DataAnnotations;

namespace BlazorClient.DTO
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string RepeatedPassword { get; set; } = string.Empty;
    }
}
