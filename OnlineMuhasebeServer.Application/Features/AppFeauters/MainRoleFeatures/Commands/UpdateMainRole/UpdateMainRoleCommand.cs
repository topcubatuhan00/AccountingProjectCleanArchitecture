using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed record UpdateMainRoleCommand(
            string Id,
            string Title
        ) : ICommand<UpdateMainRoleCommandResponse>;
}
