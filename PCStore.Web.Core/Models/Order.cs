using System.ComponentModel.DataAnnotations;

namespace PCStore.Web.Core.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Number = DateTime.Now.ToString();
        }

        [Key]
        public Guid Id { get; set; }
        public string Number { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
