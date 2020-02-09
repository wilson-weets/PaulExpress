using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Abstractions.Services
{
    public interface IOrderService
    {
        OrderDto GetOrder(int orderId);
        OrderDto Save(OrderDto order);
        void Delete(int orderId);
    }
}
