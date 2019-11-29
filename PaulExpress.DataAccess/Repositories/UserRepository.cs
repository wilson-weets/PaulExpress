using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaulExpress.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PaulExpressDBContext context) : base(context) { }
    }
}
