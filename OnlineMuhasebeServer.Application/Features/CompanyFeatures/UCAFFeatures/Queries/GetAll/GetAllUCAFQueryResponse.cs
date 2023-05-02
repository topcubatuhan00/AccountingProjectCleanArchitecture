using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Queries.GetAll;

public sealed record GetAllUCAFQueryResponse(IList<UniformChartOfAccount> Data);
