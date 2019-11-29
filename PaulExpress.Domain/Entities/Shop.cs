using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Shop : BaseEntity
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
    }
}
