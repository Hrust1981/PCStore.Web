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
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(50)]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(250)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Не указан email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public ICollection<Order>? Orders { get; set; }

        public ICollection<DiscountCard>? DiscountCards { get; set; }
    }
}
