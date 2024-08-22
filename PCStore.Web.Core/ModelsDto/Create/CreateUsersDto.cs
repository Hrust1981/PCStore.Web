namespace PCStore.Web.Core.ModelsDto.Create
{
    public class CreateUsersDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
