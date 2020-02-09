namespace PaulExpress.Domain.Entities
{
    public class ActionRole : BaseEntity
    {
        public int ActionRoleId { get; set; }
        public int ActionId { get; set; }
        public int RoleId { get; set; }

        public Action Action { get; set; }
        public Role Role { get; set; }

    }
}