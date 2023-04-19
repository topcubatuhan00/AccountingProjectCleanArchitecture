using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;

public sealed class MainRoleCommandRepository : AppQueryRepository<MainRole>, IMainRoleCommandRepository
{
    public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
    {
    }
}
