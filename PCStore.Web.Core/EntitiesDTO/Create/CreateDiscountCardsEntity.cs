namespace PCStore.Web.Core.EntitiesDTO.Create
{
    public class CreateDiscountCardsEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
