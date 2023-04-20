using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IUserAndCompanyRelationshipService
    {
        Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<UserAndCompanyRelationship> GetByIdAsync(string id);
        Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken);
        Task<IList<UserAndCompanyRelationship>> GetListByUserId(string userId);
        IQueryable<UserAndCompanyRelationship> GetAll();
        Task<IList<UserAndCompanyRelationship>> GetUserAndCompanyListByUserId(string id);
    }
}
