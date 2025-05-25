using System.ComponentModel.DataAnnotations;

namespace Task1_mvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Description { get; set; }
        public string Category { get; set; }
        public int Cuntity { get; set; }

        public float Price { get; set; }
        public float Discount { get; set; }
    }
}
