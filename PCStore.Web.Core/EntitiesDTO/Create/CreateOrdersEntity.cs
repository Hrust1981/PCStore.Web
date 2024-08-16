namespace PCStore.Web.Core.EntitiesDTO.Create
{
    public class CreateOrdersEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ShoppingCartId { get; set; }
    }
}
