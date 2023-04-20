using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed record CreateMainRoleAndRoleRLCommand(
            string RoleId,
            string MainRoleId
        ) : ICommand<CreateMainRoleAndRoleRLCommandResponse>;
}
