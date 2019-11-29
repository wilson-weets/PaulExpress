using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.DataAccess.Repositories
{
    public class SandwichRepository : GenericRepository<Sandwich>, ISandwichRepository
    {
        public SandwichRepository(PaulExpressDBContext context) : base(context) { }
    }
}
