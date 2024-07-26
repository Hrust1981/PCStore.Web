
namespace PCStore.Web.Core.Models
{
    public class Buyer
    {
        public Buyer(string name, string login, string password, string email)
        {
            DiscountCards = new List<DiscountCard>();
        }

        public bool IsAuthenticated { get; set; }
        public List<DiscountCard> DiscountCards { get; set; }
        public int TotalPurchaseAmount { get; set; }
    }
}
