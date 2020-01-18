using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.Abstractions.Services
{
    public interface IOrderService
    {
        OrderDto GetOrder(int orderId);
        void Save(OrderDto order);
    }
}
