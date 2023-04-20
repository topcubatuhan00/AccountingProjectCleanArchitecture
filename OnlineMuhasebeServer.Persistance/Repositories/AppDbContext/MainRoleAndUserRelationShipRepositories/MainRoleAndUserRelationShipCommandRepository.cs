using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationShipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationShipRepositories
{
    public sealed class MainRoleAndUserRelationShipCommandRepository
        : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationShipCommandRepository
    {
        public MainRoleAndUserRelationShipCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
