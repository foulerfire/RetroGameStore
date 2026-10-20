using System.ComponentModel.DataAnnotations;

namespace RetroGameStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        public List<Product>? Products { get; set; }
    }
}
