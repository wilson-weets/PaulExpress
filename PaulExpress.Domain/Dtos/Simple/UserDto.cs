namespace PaulExpress.Domain.Dtos.Simple
{
    public class UserDto : BaseEntityDto
    {
        public int UserId { get; set; }
        public string Trigram { get; set; }
    }
}