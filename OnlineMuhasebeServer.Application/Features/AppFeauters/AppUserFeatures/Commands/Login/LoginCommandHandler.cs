using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.AppUserFeatures.Commands.Login
{
    public sealed class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProviders _jwtProviders;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProviders jwtProviders, UserManager<AppUser> userManager)
        {
            _jwtProviders = jwtProviders;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(p => p.UserName == request.EmailOrUserName ||
            p.Email == request.EmailOrUserName).FirstOrDefaultAsync();
            if (user == null) throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Yanlış Şifre");

            List<string> roles = new();

            LoginCommandResponse response = new(
                user.Email,
                user.NameLastName,
                user.Id,
                await _jwtProviders.CreateTokenAsync(user, roles));

            return response;
        }
    }
}
