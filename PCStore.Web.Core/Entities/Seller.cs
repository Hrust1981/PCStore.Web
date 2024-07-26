namespace PCStore.Web.Core.Entities
{
    public class Seller
    {
        public Seller(string name, string login, string password, string email, Role role)
        {
        }
        public bool IsAuthenticated { get; set; }
    }
}
