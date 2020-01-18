using System;

namespace PaulExpress.Domain.Dtos.Details
{
    public class OrderGridDto
    {
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public int OrderStatusName { get; set; }
    }
}