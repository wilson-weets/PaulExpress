using System;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.Domain.Dtos.Details
{
    public class OrderLineGridDto
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string SandwichName { get; set; }
        public string SauceName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Comment { get; set; }
        public bool IsPayed { get; set; }
        public string PaymentMethodName { get; set; }
    }
}