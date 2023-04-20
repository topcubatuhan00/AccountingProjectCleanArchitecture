using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Queries.GetAllCompany;
using OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
using OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public sealed class UserAndCompanyRLController : ApiController
    {
        public UserAndCompanyRLController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllCompanyQuery query = new();
            GetAllCompanyQueryResponse res = await _mediator.Send(query);
            return Ok(res);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateUserAndCompanyRLCommand command, CancellationToken cancellationToken)
        {
            CreateUserAndCompanyRLCommandResponse res = await _mediator.Send(command,cancellationToken);
            return Ok(res);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdUserAndCompanyRLCommand command, CancellationToken cancellationToken)
        {
            RemoveByIdUserAndCompanyRLCommandResponse res = await _mediator.Send(command, cancellationToken);
            return Ok(res);
        }
    }
}
