namespace PCStore.Web.Core.Models
{
    public class CheerfulDiscountCard : DiscountCard
    {
        public CheerfulDiscountCard(int discount)
        {
            Name = "CheerfulDiscountCard";
            Discount = discount;
        }

        public new int Discount { get; }
    }
}
