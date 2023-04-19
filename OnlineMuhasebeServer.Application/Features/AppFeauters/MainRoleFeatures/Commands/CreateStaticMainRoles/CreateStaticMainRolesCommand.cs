using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateStaticRoles;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.AppEntities;
using System.Windows.Input;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed record CreateStaticMainRolesCommand(
            List<MainRole> MainRoles    
        ) : ICommand<CreateStaticMainRolesResponse>;
}
