using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.RoleDelete
{
    public sealed record DeleteRoleCommand(
            string Id
        ) : ICommand<DeleteRoleCommandResponse>;
}
