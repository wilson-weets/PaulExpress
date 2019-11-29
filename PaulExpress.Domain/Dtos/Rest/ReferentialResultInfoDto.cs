using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Domain.Dtos.Rest
{
    public class ReferentialResultInfoDto
    {
        public EReferentialTypes Type { get; set; }
        public List<ReferentialItemDto> List { get; set; }
    }
}
