using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed record RemoveByIdMainRoleCommand(
            string Id
        ) : ICommand<RemoveByIdMainRoleCommandResponse>;
}
