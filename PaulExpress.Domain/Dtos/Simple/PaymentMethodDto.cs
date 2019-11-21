namespace PaulExpress.Domain.Dtos.Simple
{
    public class PaymentMethodDto : BaseEntityDto
    {
        public int PaymentMethodId { get; set; }
        public int Name { get; set; }
    }
}