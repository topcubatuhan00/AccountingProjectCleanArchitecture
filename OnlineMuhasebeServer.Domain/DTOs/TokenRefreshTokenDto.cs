namespace OnlineMuhasebeServer.Domain.DTOs
{
    public sealed record TokenRefreshTokenDto(
        string Token,
        string RefreshToken,
        DateTime refreshTokenExpires
        );
}
