using OnlineMuhasebeServer.Application.Messaging;
using System.Windows.Input;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateStaticRoles
{
    public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;
}
