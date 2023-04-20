using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Queries.GetAll
{
    public sealed record GetAllUserAndCompanyRLQuery() : IQuery<GetAllUserAndCompanyRLQueryResponse>;
}
