using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationShipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDBContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationShipRepositories
{
    public class MainRoleAndUserRelationShipQueryRepository
        : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationShipQueryRepository
    {
        public MainRoleAndUserRelationShipQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
