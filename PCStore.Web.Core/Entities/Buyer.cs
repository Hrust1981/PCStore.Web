
namespace PCStore.Web.Core.Entities
{
    public class Buyer
    {
        public Buyer(string name, string login, string password, string email, Role role)
        {
            DiscountCards = new List<DiscountCard>();
        }

        public bool IsAuthenticated { get; set; }
        public List<DiscountCard> DiscountCards { get; set; }
        public int TotalPurchaseAmount { get; set; }
    }
}
