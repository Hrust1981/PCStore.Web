namespace PCStore.Web.Core.Models
{
    public class TransistorDiscountCard : DiscountCard
    {
        private int _discount = 10;
        public override int Discount => _discount;
    }
}
