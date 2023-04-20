using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDBContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories
{
    public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
    {
        public MainRoleAndRoleRelationshipQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
