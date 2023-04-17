using MediatR;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.RoleDelete
{
    public sealed class DeleteRoleRequest : IRequest<DeleteRoleResponse>
    {
        public string Id { get; set; }
    }
}
