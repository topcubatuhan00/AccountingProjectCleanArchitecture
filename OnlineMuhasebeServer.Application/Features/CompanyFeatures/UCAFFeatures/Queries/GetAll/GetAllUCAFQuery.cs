using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Queries.GetAll;

public sealed record GetAllUCAFQuery(string companyId) : IQuery<GetAllUCAFQueryResponse>;
