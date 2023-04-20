using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.DTOs;

namespace OnlineMuhasebeServer.Application.Abstractions
{
    public interface IJwtProviders
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);
    }
}
