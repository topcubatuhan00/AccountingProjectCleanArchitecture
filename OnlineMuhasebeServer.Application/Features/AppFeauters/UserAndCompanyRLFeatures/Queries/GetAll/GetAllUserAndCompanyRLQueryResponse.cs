using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Queries.GetAll
{
    public sealed record GetAllUserAndCompanyRLQueryResponse(
        
            IList<UserAndCompanyRelationship> userAndCompanyRelationships
        );
}
