namespace BlazorClient.DTO
{
    public class RecipeCategoryDto
    {
        public Guid Id { get; set; }
        public string Data { get; set; } = string.Empty;
        public Guid RecipeId { get; set; }
        public bool IsActive { get; set; }
    }
}
