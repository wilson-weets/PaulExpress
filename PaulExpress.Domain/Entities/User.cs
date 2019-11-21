using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Trigram { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
