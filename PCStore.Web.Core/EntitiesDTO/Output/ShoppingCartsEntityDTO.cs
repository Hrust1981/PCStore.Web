namespace PCStore.Web.Core.EntitiesDTO.Output
{
    public class ShoppingCartsEntityDTO
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
