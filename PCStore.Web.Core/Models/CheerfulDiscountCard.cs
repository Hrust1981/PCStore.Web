namespace PCStore.Web.Core.Models
{
    public class CheerfulDiscountCard : DiscountCard
    {
        private int _discount;

        public CheerfulDiscountCard(int discount)
        {
            Name = "CheerfulDiscountCard";
            _discount = discount;
        }

        public override int Discount => _discount;
    }
}
