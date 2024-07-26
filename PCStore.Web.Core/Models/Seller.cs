namespace PCStore.Web.Core.Models
{
    public class Seller
    {
        public Seller(string name, string login, string password, string email)
        {
        }
        public bool IsAuthenticated { get; set; }
    }
}
