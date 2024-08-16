using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCStore.Web.Core.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указан тип")]
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указана модель")]
        [StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указан код товара")]
        [StringLength(50)]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Заполните описание товара")]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указана цена товара")]
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public double Weight { get; set; }
        [StringLength(50)]
        public string Country { get; set; } = string.Empty;
        public int Guarantee { get; set; }

        [Required(ErrorMessage = "Не указано общее количество товара")]
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<ShoppingCart>? ShoppingCarts { get; set; }
    }
}
