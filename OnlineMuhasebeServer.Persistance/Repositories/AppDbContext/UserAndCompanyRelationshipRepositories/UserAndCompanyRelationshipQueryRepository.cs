using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDBContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public sealed class UserAndCompanyRelationshipQueryRepository
        : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
    {
        public UserAndCompanyRelationshipQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
