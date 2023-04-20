using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IMainRoleAndUserRelationshipService
    {
        Task CrateAsync(MainRoleAndUserRelationship mainRoleAndUserRelationship, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string companyId, string mainRoleId, CancellationToken cancellationToken);
        Task<MainRoleAndUserRelationship> GetByIdAsync(string id, bool isTracking);
        Task<MainRoleAndUserRelationship> GetRolesByUserIdAndCompanyId(string userId, string companyId);
        IQueryable<MainRoleAndUserRelationship> GetAll();
    }
}
