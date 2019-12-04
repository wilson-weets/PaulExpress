using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Rest;
using PaulExpress.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaulExpress.Api.Controllers
{
    [Authorize()]
    [ApiController]
    [Route("api/[controller]")]
    public class ReferentialController : ControllerBase
    {
        private readonly IReferentialService _referentialService;

        public ReferentialController(IReferentialService referencialService)
        {
            _referentialService = referencialService;
        }

        [AllowAnonymous] //For testing only
        [HttpGet("{referentialType}")]
        [Authorize()]
        public ActionResult<ReferentialResultInfoDto> Get([FromRoute] EReferentialTypes referentialType, [FromQuery] int shopId)
        {
            List<ReferentialItemDto> list = null;
            switch (referentialType)
            {
                case EReferentialTypes.Sauces:
                    list = _referentialService.GetSauces(shopId);
                break;
                case EReferentialTypes.Supplements:
                    list = _referentialService.GetSupplements(shopId);
                break;
            }
            return Ok(new ReferentialResultInfoDto()
            {
                List = list.OrderBy(c => c.DisplayValue).ToList(),
                Type = referentialType
            });
        }
    }
}
