using System;

namespace PaulExpress.Domain.Dtos.Simple
{
    public class BaseEntityDto
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}