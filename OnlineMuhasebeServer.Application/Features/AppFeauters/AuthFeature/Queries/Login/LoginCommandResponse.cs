using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.DTOs;

namespace OnlineMuhasebeServer.Application.Features.AuthFeature.Queries.Login
{
    public sealed record LoginCommandResponse(
        TokenRefreshTokenDto Token,
        string Email,
        string UserId,
        string NameLastName,
        IList<CompanyDTO> Companies,
        CompanyDTO Company
        );
}
