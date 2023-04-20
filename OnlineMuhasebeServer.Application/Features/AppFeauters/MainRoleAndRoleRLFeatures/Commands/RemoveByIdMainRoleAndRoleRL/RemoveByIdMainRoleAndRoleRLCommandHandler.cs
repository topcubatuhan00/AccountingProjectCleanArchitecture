using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand, RemoveByIdMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _service;

        public RemoveByIdMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship mainRoleAndRoleRelationship = await _service.GetByIdAsync(request.id);

            if (mainRoleAndRoleRelationship == null) throw new Exception("Silmek istediğiniz ilişki bulunamadı");

            await _service.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
