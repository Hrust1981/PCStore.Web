namespace PCStore.Web.Core.ModelsDto.Create
{
    public class CreateOrdersDto
    {
        public required string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ShoppingCartId { get; set; }
    }
}
