using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCStore.Web.Core.Models
{
    public class DiscountCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Не указан размер скидки")]
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<User> Users { get; set; } = null!;
    }
}
