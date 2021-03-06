﻿using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.DataAccess.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(PaulExpressDBContext context) : base(context)
        {
        }
    }
}
