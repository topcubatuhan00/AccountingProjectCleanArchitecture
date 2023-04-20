using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Persistance.Services.AppService
{
    public sealed class AuthService : IAuthService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;
        private readonly IMainRoleAndRoleRelationshipService _mainRoleService;

        public AuthService(UserManager<AppUser> userManager, IUserAndCompanyRelationshipService userAndCompanyRelationshipService, IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService, IMainRoleAndRoleRelationshipService mainRoleService)
        {
            _userManager = userManager;
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
            _mainRoleService = mainRoleService;
        }

        public async Task<bool> CheckPasswordAsync(AppUser appUser, string password)
        {
            return await _userManager.CheckPasswordAsync(appUser, password);
        }

        public async Task<AppUser> GetByEmailOrUsernameAsync(string emailOrUsername)
        {
            return await _userManager.Users.Where(p => p.Email == emailOrUsername || p.UserName == emailOrUsername).FirstOrDefaultAsync();
        }

        public async Task<IList<UserAndCompanyRelationship>> GetCompanyListAsync(string userId)
        {
            return await _userAndCompanyRelationshipService.GetUserAndCompanyListByUserId(userId);
        }

        public async Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            MainRoleAndUserRelationship mainRoleAndUserRelationship = await _mainRoleAndUserRelationshipService.GetRolesByUserIdAndCompanyId(userId, companyId);
            IList<MainRoleAndRoleRelationship> getRoles = await _mainRoleService.GetByIdForGetRolesAsync(mainRoleAndUserRelationship.MainRoleId);
            IList<string> roles = getRoles.Select(s => s.AppRole.Title).ToList();
            return roles;
        }
    }
}
