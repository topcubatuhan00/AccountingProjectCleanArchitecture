using MediatR;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login
{
    public sealed class LoginRequest : IRequest<LoginResponse>
    {
        public string EmailOrUserName { get; set; }
        public string Password { get; set; }
    }
}
