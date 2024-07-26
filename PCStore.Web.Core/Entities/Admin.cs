
namespace PCStore.Web.Core.Entities
{
    public class Admin
    {
        public Admin(string name, string login, string password, string email, Role role)
        {
        }

        public bool IsAuthenticated { get; set; }
    }
}
