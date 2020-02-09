using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Enums;

namespace PaulExpress.Domain.Dtos.Details
{
    public class OrderDetailDto : OrderDto
    {
        public string OrderStatusCode { get; set; }
    }
}