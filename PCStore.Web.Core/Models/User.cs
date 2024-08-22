using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCStore.Web.Core.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 2)]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(50, MinimumLength = 2)]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(50)]
        public required string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(250)]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Не указан email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public required string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        public required string PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public ICollection<Order>? Orders { get; set; }

        public ICollection<DiscountCard>? DiscountCards { get; set; }
    }
}
