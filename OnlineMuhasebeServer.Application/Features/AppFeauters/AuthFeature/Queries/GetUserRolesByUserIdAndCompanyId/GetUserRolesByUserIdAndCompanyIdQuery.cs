using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AuthFeature.Queries.GetUserRolesByUserIdAndCompanyId
{
    public sealed record GetUserRolesByUserIdAndCompanyIdQuery(
            string UserId,
            string CompanyId
        ) : IQuery<GetUserRolesByUserIdAndCompanyIdResponse>;
}
