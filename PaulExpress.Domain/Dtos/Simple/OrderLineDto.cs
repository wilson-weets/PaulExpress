namespace PaulExpress.Domain.Dtos.Simple
{
    public class OrderLineDto : BaseEntityDto
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
    }
}