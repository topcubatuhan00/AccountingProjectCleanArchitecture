using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AuthFeature.Queries.Login
{
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password
        ) : ICommand<LoginCommandResponse>;
}
