
namespace PCStore.Web.Core.Models
{
    public class Admin
    {
        public Admin(string name, string login, string password, string email)
        {
        }

        public bool IsAuthenticated { get; set; }
    }
}
