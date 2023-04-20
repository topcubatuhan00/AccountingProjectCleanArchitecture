using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Queries
{
    public sealed record GetAllMainRoleAndRoleRLQueryResponse(
            List<MainRoleAndRoleRelationship> mainRoleAndRoleRelationships
        );
}
