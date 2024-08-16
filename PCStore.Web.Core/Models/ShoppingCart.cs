using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCStore.Web.Core.Models
{
    public class ShoppingCart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Order Order { get; set; } = null!;
        public ICollection<Product>? Products { get; set; }
}
}
