using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;
        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = (CompanyDbContext)dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
