using AutoMapper;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Abstractions.Services;
using PaulExpress.Domain.Dtos.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NsiTools.EfUtils.Core;
using NsiTools.EfUtils.Core.Interfaces;
using PaulExpress.Abstractions;
using PaulExpress.Domain.Entities;

namespace PaulExpress.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IPaulExpressUnitOfWork _uow;

        public OrderService(IMapper mapper, IOrderRepository orderRepository, IPaulExpressUnitOfWork uow)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _uow = uow;
        }

        public OrderDto GetOrder(int orderId)
        {
            return _mapper.Map<OrderDto>(_orderRepository.GetById(orderId));
        }

        public OrderDto Save(OrderDto order)
        {
            Order dbo;

            if (order.OrderId > 0)
            {
                dbo = _orderRepository.GetById(order.OrderId);
                _mapper.Map(order, dbo);
                _orderRepository.Update(dbo);
            }
            else
            {
                dbo = _mapper.Map<Order>(order);
                _orderRepository.Insert(dbo);
            }

            _uow.SaveChanges(new UnitOfWorkOptions());
            return _mapper.Map<OrderDto>(dbo);
        }

        public void Delete(int orderId)
        {
            _orderRepository.Delete(orderId);
            _uow.SaveChanges(new UnitOfWorkOptions());
        }
    }
}
