namespace PaulExpress.Domain.Dtos.Simple
{
    public class SauceDto : BaseEntityDto
    {
        public int SauceId { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }
    }
}