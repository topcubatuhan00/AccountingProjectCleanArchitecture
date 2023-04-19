using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Roles;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateStaticRoles
{
    public sealed class CreateStaticRolesCommandHandler : ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateStaticRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateStaticRolesCommandResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
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
