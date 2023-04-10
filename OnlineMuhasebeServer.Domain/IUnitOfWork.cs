using Microsoft.EntityFrameworkCore;

namespace OnlineMuhasebeServer.Domain
{
    public interface IUnitOfWork
    {
        void CreateDbContextInstance(DbContext dbContext);
        Task<int> SaveChangesAsync();
    }
}
