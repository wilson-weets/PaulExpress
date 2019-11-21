using System;

namespace PaulExpress.Domain.Dtos.Simple
{
    public class OrderDto : BaseEntityDto
    {
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}