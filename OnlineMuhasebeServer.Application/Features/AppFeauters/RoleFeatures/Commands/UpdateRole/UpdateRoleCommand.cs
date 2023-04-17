using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(
            string Id,
            string Code,
            string Name
        ) : ICommand<UpdateRoleCommandResponse>;
}
