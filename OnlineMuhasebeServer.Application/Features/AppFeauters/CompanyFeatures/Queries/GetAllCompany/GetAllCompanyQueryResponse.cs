using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Queries.GetAllCompany;

public sealed record GetAllCompanyQueryResponse(
    IList<Company> Companies
    );
