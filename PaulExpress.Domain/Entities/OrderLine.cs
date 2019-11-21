using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int UserId { get; set; }
        public int SandwichId { get; set; }
        public int? SauceId { get; set; }
        public int? OrderLineSupplementId { get; set; }
        public int PaymentMethodId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
        public bool IsPayed { get; set; }

        public List<OrderLineSupplement> OrderLineSupplements { get; set; }

    }
}
