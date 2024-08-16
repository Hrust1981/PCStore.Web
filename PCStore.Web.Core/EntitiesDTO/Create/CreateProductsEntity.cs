namespace PCStore.Web.Core.EntitiesDTO.Create
{
    public class CreateProductsEntity
    {
        public string Type { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string Country { get; set; } = string.Empty;
        public int Guarantee { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
