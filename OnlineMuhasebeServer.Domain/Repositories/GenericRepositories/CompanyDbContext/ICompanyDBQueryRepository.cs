using OnlineMuhasebeServer.Domain.Abstractions;
using System.Linq.Expressions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDBQueryRepository<T> : ICompanyDBRepository<T>, IQueryGenericRepository<T> where T : Entity
    {
        
    }
}
