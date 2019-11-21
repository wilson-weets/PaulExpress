using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public Datetime StartDate { get; set; }
        public Datetime EndDate { get; set; }
        public string Comment { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}
