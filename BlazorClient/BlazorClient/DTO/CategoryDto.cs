using System.ComponentModel.DataAnnotations;

namespace BlazorClient.DTO
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="The category name is required")]
        public string Data { get; set; } = string.Empty;
        public Boolean IsActive { get; set; }
    }
}
