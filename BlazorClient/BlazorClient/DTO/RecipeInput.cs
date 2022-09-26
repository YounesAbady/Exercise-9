using System.ComponentModel.DataAnnotations;

namespace BlazorClient.DTO
{
    public class RecipeInput
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Ingredients { get; set; } = string.Empty;
        [Required]
        public string Instructions { get; set; } = string.Empty;
        [Required]
        [MinLength(1, ErrorMessage = "you must pick atleast 1 category"), MaxLength(10)]
        public string[] Categories { get; set; } = new string[10];
    }
}
