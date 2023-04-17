using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.MigrateCompanyDatabase;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request,CancellationToken cancellationToken)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabaseCommand request = new MigrateCompanyDatabaseCommand();
            MigrateCompanyDatabaseCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
