using OnlineMuhasebeServer.Application.Messaging;
using System.Windows.Input;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateAllRoles
{
    public sealed record CreateAllRolesCommand() : ICommand<CreateAllRolesCommandResponse>;
}
