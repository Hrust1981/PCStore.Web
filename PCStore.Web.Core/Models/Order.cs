using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCStore.Web.Core.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; } = null!;
    }
}
