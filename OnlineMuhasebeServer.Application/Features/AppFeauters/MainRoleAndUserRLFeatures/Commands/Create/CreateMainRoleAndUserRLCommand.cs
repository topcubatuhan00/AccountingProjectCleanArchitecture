using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.Create
{
    public sealed record CreateMainRoleAndUserRLCommand(
            string userId,
            string mainRoleId,
            string companyId
        ) : ICommand<CreateMainRoleAndUserRLCommandResponse>;
}
