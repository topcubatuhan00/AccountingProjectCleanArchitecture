using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.AuthFeature.Queries.GetUserRolesByUserIdAndCompanyId;
using OnlineMuhasebeServer.Application.Features.AuthFeature.Queries.Login;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand loginRequest)
        {
            LoginCommandResponse response = await _mediator.Send(loginRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetRoleById(GetUserRolesByUserIdAndCompanyIdQuery query)
        {
            GetUserRolesByUserIdAndCompanyIdResponse response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
