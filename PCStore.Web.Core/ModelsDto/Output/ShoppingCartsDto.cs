namespace PCStore.Web.Core.ModelsDto.Output
{
    public class ShoppingCartsDto
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
