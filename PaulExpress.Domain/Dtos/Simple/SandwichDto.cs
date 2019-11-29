namespace PaulExpress.Domain.Dtos.Simple
{
    public class SandwichDto : BaseEntityDto
    {
        public int SandwichId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public double UnitPrice { get; set; }
    }
}