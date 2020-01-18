using System.Collections.Generic;

namespace PaulExpress.Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        public int OrderStatusId { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}