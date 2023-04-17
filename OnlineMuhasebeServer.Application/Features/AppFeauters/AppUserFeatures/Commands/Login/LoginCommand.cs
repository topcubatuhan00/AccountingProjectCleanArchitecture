using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password
        ) : ICommand<LoginCommandResponse>;
}
