using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDBRepository<T> : IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext dbContext);
    }
}
