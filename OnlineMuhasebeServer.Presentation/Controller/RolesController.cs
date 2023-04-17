﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole;
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
        public async Task<IActionResult> CreateRole(CreateRoleRequest createRoleRequest)
        {
            CreateRoleResponse response = await _mediator.Send(createRoleRequest);
            return Ok(response);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesRequest request = new();
            GetAllRolesResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest updateRoleRequest)
        {
            UpdateRoleResponse response = await _mediator.Send(updateRoleRequest);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleRequest request = new()
            {
                Id = id,
            };

            DeleteRoleResponse response = await _mediator.Send(request);
            return Ok(response);

        }
    }
}
