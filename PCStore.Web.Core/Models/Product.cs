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
        public required string Type { get; set; }

        [Required(ErrorMessage = "Не указана модель")]
        [StringLength(50)]
        public required string Model { get; set; }

        [Required(ErrorMessage = "Не указан код товара")]
        [StringLength(50)]
        public required string Code { get; set; }

        [Required(ErrorMessage = "Заполните описание товара")]
        [StringLength(1000)]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Не указана цена товара")]
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public double Weight { get; set; }
        [StringLength(50)]
        public required string Country { get; set; }
        public int Guarantee { get; set; }

        [Required(ErrorMessage = "Не указано общее количество товара")]
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<ShoppingCart>? ShoppingCarts { get; set; }
    }
}
