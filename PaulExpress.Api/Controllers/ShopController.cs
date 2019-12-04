using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.Api.Controllers
{
    [Authorize()]
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;
        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [AllowAnonymous]
        [HttpGet("sandwich/{shopId}")]
        public ActionResult<List<SandwichDto>> Get([FromRoute] int shopId)
        {
            return Ok(_shopService.GetSandwichesFromShop(shopId));
        }
    }
}