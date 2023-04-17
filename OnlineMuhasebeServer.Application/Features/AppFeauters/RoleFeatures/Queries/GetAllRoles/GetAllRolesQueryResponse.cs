using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesQueryResponse(
            IList<AppRole> Roles
        );
}
