using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateMainUcaf;

public sealed class CreateMainUcafCommandHandler : ICommandHandler<CreateMainUcafCommand, CreateMainUcafCommandResponse>
{
    private readonly IUCAFService _service;

    public CreateMainUcafCommandHandler(IUCAFService service)
    {
        _service = service;
    }

    public async Task<CreateMainUcafCommandResponse> Handle(CreateMainUcafCommand request, CancellationToken cancellationToken)
    {
        await _service.CreateMainUcafsToCompanyAsync(request.companyId,cancellationToken);
        return new();
    }
}
