using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public int Name { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
