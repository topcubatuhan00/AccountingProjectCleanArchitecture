using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void CreateDbContextInstance(DbContext dbContext);
        DbSet<T> Entity { get;  set; }
    }
}
