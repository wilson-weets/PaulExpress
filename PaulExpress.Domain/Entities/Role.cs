using System.Collections.Generic;

namespace PaulExpress.Domain.Entities
{
    public class Role : BaseEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public List<UserRole> UserRoles { get; set; }
        public List<ActionRole> ActionRoles { get; set; }
    }
}