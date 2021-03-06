﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Trigram { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
