namespace PCStore.Web.Core.Models
{
    public class ShoppingCart
    {
        // For testing
        public ShoppingCart(Guid id, List<Product> products, Guid userId)
        {
            UserId = id;
            Products = products;
            UserId = userId;
        }

        public ShoppingCart(List<Product> products, Guid userId)
        {
            Id = Guid.NewGuid();
            Products = products;
            UserId = userId;
        }

        public Guid UserId { get; set; }
        public List<Product> Products { get; set; }
    }
}
