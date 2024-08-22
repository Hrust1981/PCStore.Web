namespace PCStore.Web.Core.ModelsDto.Output
{
    public class DiscountCardsDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
