using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Entities
{
    public class OrderLineSupplement : BaseEntity
    {
        public int OrderLineSupplementId { get; set; }
        public int OrderLineId { get; set; }
        public int SupplementId { get; set; }

    }
}
