using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            LoginResponse response =  await _mediator.Send(loginRequest);
            return Ok(response);
        }
    }
}
