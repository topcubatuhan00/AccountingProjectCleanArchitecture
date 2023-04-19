using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Queries.GetAllCompany
{
    public sealed record GetAllCompanyQuery() : IQuery<GetAllCompanyQueryResponse>;
}
