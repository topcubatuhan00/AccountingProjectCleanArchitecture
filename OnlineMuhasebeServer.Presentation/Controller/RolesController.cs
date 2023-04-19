using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateStaticRoles;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.RoleDelete;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.UpdateRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Queries.GetAllRoles;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleCommand createRoleRequest)
        {
            CreateRoleCommandResponse response = await _mediator.Send(createRoleRequest);
            return Ok(response);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesQuery request = new();
            GetAllRolesQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand updateRoleRequest)
        {
            UpdateRoleCommandResponse response = await _mediator.Send(updateRoleRequest);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleCommand request = new(Id: id);

            DeleteRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> CreateAllRoles()
        {
            CreateStaticRolesCommand request = new();
            CreateStaticRolesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
