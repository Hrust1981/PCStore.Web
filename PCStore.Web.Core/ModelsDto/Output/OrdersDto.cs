namespace PCStore.Web.Core.ModelsDto.Output
{
    public class OrdersDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
