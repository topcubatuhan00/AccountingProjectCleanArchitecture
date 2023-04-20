using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public sealed class UserAndCompanyRelationshipCommandRepository
        : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
    {
        public UserAndCompanyRelationshipCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
