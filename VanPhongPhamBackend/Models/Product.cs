using System.ComponentModel.DataAnnotations;

namespace VanPhongPhamBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required] public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required] public decimal Price { get; set; }
    }
}