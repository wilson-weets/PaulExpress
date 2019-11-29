using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.DataAccess.Repositories
{
    public public class ShopRepository: GenericRepository<Shop>, IShopRepository
    {
        public ShopRepository(PaulExpressDBContext context) : base(context) { }
    }
}
