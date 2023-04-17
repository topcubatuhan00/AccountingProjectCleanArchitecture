using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(
            string Name,
            string Code
        )
        : ICommand<CreateRoleCommandResponse>;
    
}
