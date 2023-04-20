using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.Create;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.RemoveById;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Queries.GetAll;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public sealed class MainRoleAndUserRLController : ApiController
    {
        public MainRoleAndUserRLController(IMediator mediator) : base(mediator)
        {
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllMainRoleAndUserRLQuery query = new();
            GetAllMainRoleAndUserRLQueryResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleAndUserRLCommand command)
        {
            CreateMainRoleAndUserRLCommandResponse response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndUserRLCommand command)
        {
            RemoveByIdMainRoleAndUserRLCommandResponse response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
