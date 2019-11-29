using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.DataAccess.Repositories
{
    public class OrderLineRepository : GenericRepository<OrderLine>, IOrderLineRepository
    {
        public OrderLineRepository(PaulExpressDBContext context): base(context)
        {

        }
    }
}
