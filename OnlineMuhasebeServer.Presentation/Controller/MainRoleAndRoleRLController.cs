using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Queries;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public sealed class MainRoleAndRoleRLController : ApiController
    {
        public MainRoleAndRoleRLController(IMediator mediator) : base(mediator)
        {
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllMainRoleAndRoleRLQuery query = new();
            GetAllMainRoleAndRoleRLQueryResponse response = await _mediator.Send(query);
            return Ok(response);
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleAndRoleRLCommand command, CancellationToken cancellationToken)
        {
            CreateMainRoleAndRoleRLCommandResponse response = await _mediator.Send(command,cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(RemoveByIdMainRoleAndRoleRLCommand request)
        {
            RemoveByIdMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
