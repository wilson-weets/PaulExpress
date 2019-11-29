using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class Supplement : BaseEntity
    {
        public int SupplementId { get; set; }
        public int Name { get; set; }
        public int UnitPrice { get; set; }
        public int ShopId { get; set; }
        public List<OrderLineSupplement> OrderLineSupplements { get; set; }
    }
}
