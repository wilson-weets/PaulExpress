using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Sauce : BaseEntity
    {
        public int SauceId { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
