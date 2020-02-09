using System.Collections.Generic;

namespace PaulExpress.Domain.Entities
{
    public class Action : BaseEntity
    {
        public int ActionId { get; set; }
        public string Code { get; set; }

        public List<ActionRole> ActionRoles { get; set; }
    }
}