using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AuthFeature.Queries.GetUserRolesByUserIdAndCompanyId
{
    public sealed class GetUserRolesByUserIdAndCompanyIdHandler : IQueryHandler<GetUserRolesByUserIdAndCompanyIdQuery, GetUserRolesByUserIdAndCompanyIdResponse>
    {
        private readonly IAuthService _authService;

        public GetUserRolesByUserIdAndCompanyIdHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<GetUserRolesByUserIdAndCompanyIdResponse> Handle(GetUserRolesByUserIdAndCompanyIdQuery request, CancellationToken cancellationToken)
        {
            IList<string> roles = await _authService.GetRolesByUserIdAndCompanyId(request.UserId, request.CompanyId);
            return new(roles);
        }
    }
}
