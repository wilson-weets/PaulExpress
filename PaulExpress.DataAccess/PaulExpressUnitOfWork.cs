using Microsoft.EntityFrameworkCore;
using NsiTools.EfUtils.Core;
using NsiTools.EfUtils.Core.Interfaces;
using PaulExpress.Abstractions;

namespace PaulExpress.DataAccess
{
    public class PaulExpressUnitOfWork : UnitOfWork, IPaulExpressUnitOfWork
    {
        private readonly PaulExpressDBContext _dbContext;

        public PaulExpressUnitOfWork(PaulExpressDBContext dbContext, IAuthorTraceability authorTraceability) : base(dbContext, authorTraceability)
        {
            _dbContext = dbContext;
        }
    }
}