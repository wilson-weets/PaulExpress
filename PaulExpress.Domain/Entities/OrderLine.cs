using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class OrderLine : BaseEntity
    {
        public int OrderLineId { get; set; }
        public int UserId { get; set; }
        public int SandwichId { get; set; }
        public int? SauceId { get; set; }
        public int PaymentMethodId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
        public bool IsPayed { get; set; }

        public List<OrderLineSupplement> OrderLineSupplements { get; set; }
        public Sandwich Sandwich { get; set; }
        public Sauce Sauce { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Order Order { get; set; }
    }
}
