﻿namespace PaulExpress.Domain.Dtos.Simple
{
    public class ActionRoleDto : BaseEntityDto
    {
        public int ActionRoleId { get; set; }
        public int ActionId { get; set; }
        public int RoleId { get; set; }
    }
}