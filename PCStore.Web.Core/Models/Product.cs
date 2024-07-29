using System.ComponentModel.DataAnnotations;

namespace PCStore.Web.Core.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указан тип")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Не указана модель")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Не указан код товара")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Заполните описание товара")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Не указана цена товара")]
        public decimal Price { get; set; }

        public int Weight { get; set; }
        public string Country { get; set; }
        public int Waranty { get; set; }

        [Required(ErrorMessage = "Не указано общее количество товара")]
        public int Quantity { get; set; }

        public Guid? ShoppingCartId { get; set; }
        public List<ShoppingCart>? ShoppingCarts { get; set; }
    }
}
