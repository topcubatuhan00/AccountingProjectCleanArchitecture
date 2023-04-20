using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateStaticRoles
{
    public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;
}
