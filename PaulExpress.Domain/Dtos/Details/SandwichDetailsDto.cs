using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Dtos.Details
{
    public class SandwichDetailsDto : SandwichDto
    {
        public SauceDto Sauce { get; set; }
        public List<SupplementDto> Supplements { get; set; }  
    }
}
