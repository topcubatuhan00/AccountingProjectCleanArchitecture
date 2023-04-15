using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Abstractions
{
    public interface IJwtProviders
    {
        Task<string> CreateTokenAsync(AppUser user, List<string> roles);
    }
}
