using System.ComponentModel.DataAnnotations;

namespace RetroGameStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]

        public required string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")] //formats to proper pricing format
        [Range(0.01, 999999)]
        public double Price { get; set;}
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string? Photo { get; set; }

        public string? Description { get; set; }

        public Category? Category { get; set; }
    }
}
