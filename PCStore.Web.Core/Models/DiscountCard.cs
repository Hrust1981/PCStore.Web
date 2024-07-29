using System.ComponentModel.DataAnnotations;

namespace PCStore.Web.Core.Models
{
    public class DiscountCard
    {
        public DiscountCard()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан размер скидки")]
        public virtual int Discount { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}
