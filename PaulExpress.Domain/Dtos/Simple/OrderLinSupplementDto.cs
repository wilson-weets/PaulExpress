﻿namespace PaulExpress.Domain.Dtos.Simple
{
    public class OrderLinSupplementDto : BaseEntityDto
    {
        public int OrderLineSupplementId { get; set; }
        public int OrderLineId { get; set; }
        public int SupplementId { get; set; }
    }
}