using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed record CreateStaticMainRolesCommand(
            List<MainRole> MainRoles
        ) : ICommand<CreateStaticMainRolesResponse>;
}
