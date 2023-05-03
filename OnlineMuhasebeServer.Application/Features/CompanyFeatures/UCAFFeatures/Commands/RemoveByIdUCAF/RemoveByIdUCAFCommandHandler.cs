using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.RemoveByIdUCAF;

public sealed class RemoveByIdUCAFCommandHandler : ICommandHandler<RemoveByIdUCAFCommand, RemoveByIdUCAFCommandResponse>
{
    private readonly IUCAFService _service;

    public RemoveByIdUCAFCommandHandler(IUCAFService service)
    {
        _service = service;
    }

    public async Task<RemoveByIdUCAFCommandResponse> Handle(RemoveByIdUCAFCommand request, CancellationToken cancellationToken)
    {
        var condition = await _service.CheckRemoveByIdUCAFAvailable(request.CompanyId, request.Id);
        if (!condition) throw new Exception("Silmek istediğiniz hesap planının alt hesapları bulunmaktadır.");
        await _service.RemoveById(request.CompanyId, request.Id,cancellationToken);
        return new();
    }
}
