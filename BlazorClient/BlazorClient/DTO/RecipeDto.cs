using System.ComponentModel.DataAnnotations;

namespace BlazorClient.DTO
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public List<IngredientDto> Ingredients { get; set; } = new();
        [Required]
        public List<InstructiontDto> Instructions { get; set; } = new();
        [Required]
        public List<RecipeCategoryDto> RecipeCategories { get; set; } = new();
    }
}
