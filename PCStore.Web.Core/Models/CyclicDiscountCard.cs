namespace PCStore.Web.Core.Models
{
    public class CyclicDiscountCard : DiscountCard
    {
        public CyclicDiscountCard()
        {
            Name = "CyclicDiscountCard";
        }

        public CyclicDiscountCard(int discount, int totalPurchaseAmount)
        {
            Name = "CyclicDiscountCard";
            Discount = discount;
            TotalPurchaseAmount = totalPurchaseAmount;
        }

        public new int Discount { get; }

        public int TotalPurchaseAmount { get; set; }
    }
}
