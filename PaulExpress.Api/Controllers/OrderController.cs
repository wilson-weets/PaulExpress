using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NsiTools.EfUtils.Core.SearchBase;
using NsiTools.Mvc.Core.Controllers;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Details;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.SearchObjects;

namespace PaulExpress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : SearchControllerBase<OrderSearch, OrderGridDto>
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public override ActionResult<PaginatedResults<OrderGridDto>> BaseSearch(OrderSearch sObj)
        {
            throw new NotImplementedException();
        }

        [HttpPost("save")]
        public ActionResult<OrderDto> Get(OrderDto order)
        {
            _orderService.Save(order);
            return Ok();
        }
    }
}