using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdMainRoleAndUserRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndUserRLCommand, RemoveByIdMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;

        public RemoveByIdMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService)
        {
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
        }

        public async Task<RemoveByIdMainRoleAndUserRLCommandResponse> Handle(RemoveByIdMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship role = await _mainRoleAndUserRelationshipService.GetByIdAsync(request.id,false);
            if (role == null) throw new Exception("Silmek istediğiniz ilişki bulunamadı");

            await _mainRoleAndUserRelationshipService.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
