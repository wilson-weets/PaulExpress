using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Sauce
    {
        public int SauceId { get; set; }
        public string Name { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
