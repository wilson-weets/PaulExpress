using Microsoft.EntityFrameworkCore;
using NsiTools.EfUtils.Core;
using PaulExpress.Abstractions.Repositories;
using PaulExpress.Domain.Entities;

namespace PaulExpress.DataAccess.Repositories
{
    public class ActionRepository : GenericRepository<Action>, IActionRepository
    {
        public ActionRepository(DbContext context) : base(context)
        {
        }
    }
}