using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDBCommandRepository<T> : ICompanyDBRepository<T>, ICommandGenericRepository<T>
        where T : Entity
    {

    }
}
