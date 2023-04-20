using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDBQueryRepository<T> : ICompanyDBRepository<T>, IQueryGenericRepository<T> where T : Entity
    {

    }
}
