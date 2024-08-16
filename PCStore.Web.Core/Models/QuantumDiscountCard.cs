namespace PCStore.Web.Core.Models
{
    public class QuantumDiscountCard : DiscountCard
    {
        public QuantumDiscountCard()
        {
            Name = "QuantumDiscountCard";
        }

        public new int Discount { get; } = 20;
    }
}
