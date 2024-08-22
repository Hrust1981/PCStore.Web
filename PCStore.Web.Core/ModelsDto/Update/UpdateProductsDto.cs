namespace PCStore.Web.Core.ModelsDto.Update
{
    public class UpdateProductsDto
    {
        public Guid Id { get; set; }
        public required string Type { get; set; }
        public required string Model { get; set; }
        public required string Code { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public required string Country { get; set; }
        public int Guarantee { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
