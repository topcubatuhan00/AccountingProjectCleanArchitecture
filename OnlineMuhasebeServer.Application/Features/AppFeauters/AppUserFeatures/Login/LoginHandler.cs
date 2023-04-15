using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Login
{
    public sealed class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProviders _jwtProviders;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(IJwtProviders jwtProviders, UserManager<AppUser> userManager)
        {
            _jwtProviders = jwtProviders;
            _userManager = userManager;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(p => p.UserName == request.EmailOrUserName ||
            p.Email == request.EmailOrUserName).FirstOrDefaultAsync();
            if (user == null) throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Yanlış Şifre");

            List<string> roles = new();

            LoginResponse response = new()
            {
                Email = user.Email,
                NameLastName = user.NameLastName,
                UserId = user.Id,
                Token = await _jwtProviders.CreateTokenAsync(user, roles)
            };

            return response;
        }
    }
}
