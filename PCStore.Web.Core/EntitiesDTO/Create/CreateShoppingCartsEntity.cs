namespace PCStore.Web.Core.EntitiesDTO.Create
{
    public class CreateShoppingCartsEntity
    {
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UserId { get; set; }
    }
}
