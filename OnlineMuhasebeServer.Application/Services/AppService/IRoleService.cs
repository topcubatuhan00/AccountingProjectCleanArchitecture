using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        Task UpdateAsync(AppRole role);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetByCode(string code);
        Task<AppRole> GetById(string code);
    }
}
