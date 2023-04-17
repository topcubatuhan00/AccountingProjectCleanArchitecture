namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string Email,
        string UserId,
        string NameLastName
        );
}
