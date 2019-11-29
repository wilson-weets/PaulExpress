using AutoMapper;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaulExpress.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public OrderDto GetOrder(int orderId)
        {
            return _mapper.Map<OrderDto>(_orderRepository.GetById(orderId));
        }

    }
}
