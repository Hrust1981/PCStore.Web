namespace PCStore.Web.Core.EntitiesDTO.Output
{
    public class DiscountCardsEntityDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
