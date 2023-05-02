using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Queries.GetAll;

public sealed class GetAllUCAFQueryHandler : IQueryHandler<GetAllUCAFQuery, GetAllUCAFQueryResponse>
{
    private readonly IUCAFService _service;

    public GetAllUCAFQueryHandler(IUCAFService service)
    {
        _service = service;
    }

    public async Task<GetAllUCAFQueryResponse> Handle(GetAllUCAFQuery request, CancellationToken cancellationToken)
    {
        return new(await _service.GetAllAsync(request.companyId));
    }
}
