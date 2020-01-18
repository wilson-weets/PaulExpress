namespace PaulExpress.Domain.Dtos.Simple
{
    public class OrderStatusDto : BaseEntityDto
    {
        public int OrderStatusId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}