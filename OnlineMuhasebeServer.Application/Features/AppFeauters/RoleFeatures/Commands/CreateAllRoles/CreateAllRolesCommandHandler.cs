using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Roles;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateAllRoles
{
    public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateAllRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoles = RoleList.GetStaticRoles();
            IList<AppRole> newRoles = new List<AppRole>();


            foreach (var role in originalRoles)
            {
                AppRole checkRole = await _roleService.GetByCode(role.Code);
                if (checkRole == null)
                {
                    newRoles.Add(role);
                }
            }
            await _roleService.AddRangeAsync(newRoles);
            return new();
        }

    }
}
