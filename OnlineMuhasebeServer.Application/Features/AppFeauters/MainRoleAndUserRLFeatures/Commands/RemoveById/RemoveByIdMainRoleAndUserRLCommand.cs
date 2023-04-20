using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.RemoveById
{
    public sealed record RemoveByIdMainRoleAndUserRLCommand(
            string id
        ) : ICommand<RemoveByIdMainRoleAndUserRLCommandResponse>;
}
