using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed record RemoveByIdMainRoleAndRoleRLCommand(
            string id
        ) : ICommand<RemoveByIdMainRoleAndRoleRLCommandResponse>;
}
