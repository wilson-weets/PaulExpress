using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public int OrderStatusId { get; set; }

        public List<OrderLine> OrderLines { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
