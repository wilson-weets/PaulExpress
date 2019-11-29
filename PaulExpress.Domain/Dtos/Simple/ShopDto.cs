using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Dtos.Simple
{
    public class ShopDto : BaseEntityDto
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
