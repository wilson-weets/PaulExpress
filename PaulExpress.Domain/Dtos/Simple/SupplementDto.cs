namespace PaulExpress.Domain.Dtos.Simple
{
    public class SupplementDto : BaseEntityDto
    {
        public int SupplementId { get; set; }
        public int Name { get; set; }
        public int UnitPrice { get; set; }
        public int ShopId { get; set; }
    }
}