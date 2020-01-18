using Microsoft.EntityFrameworkCore;
using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;

namespace PaulExpress.DataAccess.Repositories
{
    public class OrderStatusRepository : GenericRepository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(DbContext context) : base(context)
        {
        }
    }
}