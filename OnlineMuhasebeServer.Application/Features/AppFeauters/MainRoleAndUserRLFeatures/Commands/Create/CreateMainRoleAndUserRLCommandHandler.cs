using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.Create
{
    public sealed class CreateMainRoleAndUserRLCommandHandler : ICommandHandler<CreateMainRoleAndUserRLCommand, CreateMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;

        public CreateMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService)
        {
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
        }

        public async Task<CreateMainRoleAndUserRLCommandResponse> Handle(CreateMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship role = await _mainRoleAndUserRelationshipService.GetByUserIdCompanyIdAndMainRoleIdAsync(request.mainRoleId, request.userId, request.companyId, cancellationToken);

            if (role != null) throw new Exception("Eklemek Istediğiniz İlişki Zaten Ekli");

            MainRoleAndUserRelationship mainRole = new(
                    Id: Guid.NewGuid().ToString(),
                    userId: request.userId,
                    companyId: request.companyId,
                    mainRoleId: request.mainRoleId
                );

            await _mainRoleAndUserRelationshipService.CrateAsync(mainRole, cancellationToken);
            return new();
        }
    }
}
