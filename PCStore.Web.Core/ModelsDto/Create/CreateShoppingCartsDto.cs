namespace PCStore.Web.Core.ModelsDto.Create
{
    public class CreateShoppingCartsDto
    {
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UserId { get; set; }
    }
}
