using Microsoft.EntityFrameworkCore;
using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;

namespace PaulExpress.DataAccess.Repositories
{
    public class ActionRoleRepository : GenericRepository<ActionRole>, IActionRoleRepository
    {
        public ActionRoleRepository(DbContext context) : base(context)
        {
        }
    }
}