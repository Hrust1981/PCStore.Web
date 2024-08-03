using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
