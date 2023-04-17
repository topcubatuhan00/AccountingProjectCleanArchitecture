namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string Email,
        string UserId,
        string NameLastName
        );
}
