﻿namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login
{
    public sealed class LoginResponse
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string NameLastName { get; set; }
    }
}
