namespace PCStore.Web.Core.ModelsDto.Create
{
    public class CreateDiscountCardsDto
    {
        public required string Name { get; set; }
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
