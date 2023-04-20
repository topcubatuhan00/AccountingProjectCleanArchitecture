namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AuthFeature.Queries.GetUserRolesByUserIdAndCompanyId
{
    public sealed record GetUserRolesByUserIdAndCompanyIdResponse(
            IList<string> Roles
        );
}
