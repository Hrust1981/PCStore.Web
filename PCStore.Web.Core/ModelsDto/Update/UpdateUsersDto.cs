namespace PCStore.Web.Core.ModelsDto.Update
{
    public class UpdateUsersDto
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
