using Microsoft.EntityFrameworkCore;

namespace OnlineMuhasebeServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext dbContext);
        Task<int> SaveChangesAsync();
    }
}
