using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
