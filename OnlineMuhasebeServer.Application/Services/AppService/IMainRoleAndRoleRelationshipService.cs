using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IMainRoleAndRoleRelationshipService
    {
        Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken);
        Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship);
        Task RemoveByIdAsync(string id);
        IQueryable<MainRoleAndRoleRelationship> GetAll();
        Task<MainRoleAndRoleRelationship> GetByIdAsync(string id);
        Task<IList<MainRoleAndRoleRelationship>> GetListByMainRoleIdForGetRolesAsync(string id);
        Task<MainRoleAndRoleRelationship> GetRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default);
        Task<IList<MainRoleAndRoleRelationship>> GetByIdForGetRolesAsync(string id);
    }
}
