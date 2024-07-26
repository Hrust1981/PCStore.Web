using System.ComponentModel.DataAnnotations;

namespace PCStore.Web.Core.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Country { get; set; }
        public int Waranty { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
