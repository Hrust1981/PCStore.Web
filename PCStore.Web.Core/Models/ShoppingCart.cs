using System.ComponentModel.DataAnnotations;

namespace PCStore.Web.Core.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public List<Product>? Products { get; set; }
    }
}
