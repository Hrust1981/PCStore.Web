namespace PCStore.Web.Core.EntitiesDTO.Output
{
    public class OrdersEntityDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
