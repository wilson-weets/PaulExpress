using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Sandwich : BaseEntity
    {
        public int SandwichId { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public double UnitPrice { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
