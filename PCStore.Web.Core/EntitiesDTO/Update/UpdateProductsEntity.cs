﻿namespace PCStore.Web.Core.EntitiesDTO.Update
{
    public class UpdateProductsEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string Country { get; set; } = string.Empty;
        public int Guarantee { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
