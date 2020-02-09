namespace PaulExpress.Domain.Dtos.Simple
{
    public class UserRoleDto : BaseEntityDto
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}