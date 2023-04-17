using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password
        ) : ICommand<LoginCommandResponse>;
}
