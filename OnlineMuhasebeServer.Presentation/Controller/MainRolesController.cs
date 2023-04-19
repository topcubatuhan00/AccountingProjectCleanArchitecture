using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateStaticMainRoles;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.RemoveMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.UpdateMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Queries.GetAllMainRole;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller;

public class MainRolesController : ApiController
{
    public MainRolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        CreateMainRoleCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);    
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateStaticMainRoles(CancellationToken cancellationToken)
    {
        CreateStaticMainRolesCommand request = new(null);
        CreateStaticMainRolesResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        GetAllMainRoleQuery request = new();
        GetAllMainRoleResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveMainRoleById(RemoveByIdMainRoleCommand request)
    {
        RemoveByIdMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Update(UpdateMainRoleCommand request)
    {
        UpdateMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
