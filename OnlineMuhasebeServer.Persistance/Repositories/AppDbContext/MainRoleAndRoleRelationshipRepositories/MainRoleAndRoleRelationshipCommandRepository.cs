using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories
{
    public sealed class MainRoleAndRoleRelationshipCommandRepository
        : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipCommandRepository
    {
        public MainRoleAndRoleRelationshipCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
