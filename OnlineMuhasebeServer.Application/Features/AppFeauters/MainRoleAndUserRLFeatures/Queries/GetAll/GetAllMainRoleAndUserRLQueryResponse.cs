using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Queries.GetAll
{
    public sealed record GetAllMainRoleAndUserRLQueryResponse(
            IList<MainRoleAndUserRelationship> mainRoleAndUserRelationships
        );
}
