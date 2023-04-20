using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;

public sealed class CreateMainRoleAndRoleRLCommandHandler : ICommandHandler<CreateMainRoleAndRoleRLCommand, CreateMainRoleAndRoleRLCommandResponse>
{
    private readonly IMainRoleAndRoleRelationshipService _service;

    public CreateMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService service)
    {
        _service = service;
    }

    public async Task<CreateMainRoleAndRoleRLCommandResponse> Handle(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
    {
        MainRoleAndRoleRelationship checkRoleAndMainRoleIsRelated = await _service.GetRoleIdAndMainRoleId(request.RoleId, request.MainRoleId, cancellationToken);

        if (checkRoleAndMainRoleIsRelated != null) throw new Exception("Bu Rol Ilişkisi Daha Once Kurulmuş");

        MainRoleAndRoleRelationship mainRoleAndRoleRelationship = new();
        mainRoleAndRoleRelationship.Id = Guid.NewGuid().ToString();
        mainRoleAndRoleRelationship.MainRoleId = request.MainRoleId;
        mainRoleAndRoleRelationship.RoleId = request.RoleId;

        await _service.CreateAsync(mainRoleAndRoleRelationship,cancellationToken);
        return new();
    }
}
