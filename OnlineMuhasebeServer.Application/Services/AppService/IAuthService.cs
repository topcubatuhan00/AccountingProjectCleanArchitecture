using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IAuthService
    {
        Task<AppUser> GetByEmailOrUsernameAsync(string emailOrUsername);
        Task<bool> CheckPasswordAsync(AppUser appUser, string password);
        Task<IList<UserAndCompanyRelationship>> GetCompanyListAsync(string userId);
        Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId);
    }
}
