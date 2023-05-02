using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.DTOs;

namespace OnlineMuhasebeServer.Application.Features.AuthFeature.Queries.Login
{
    public sealed class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProviders _jwtProviders;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthService _authService;

        public LoginCommandHandler(IJwtProviders jwtProviders, UserManager<AppUser> userManager, IAuthService authService)
        {
            _jwtProviders = jwtProviders;
            _userManager = userManager;
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _authService.GetByEmailOrUsernameAsync(request.EmailOrUserName);
            if (user == null) throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Yanlış Şifre");

            IList<UserAndCompanyRelationship> companies = await _authService.GetCompanyListAsync(user.Id);
            IList<CompanyDTO> companiesDto = companies.Select(s => new CompanyDTO(s.Company.Id, s.Company.Name)).ToList();


            if (companies.Count == 0) throw new Exception("Kullanıcı herhangi bir şirkete kayıtlı değil");

            LoginCommandResponse response = new(
                Token: await _jwtProviders.CreateTokenAsync(user),
                Email: user.Email,
                UserId: user.Id,
                NameLastName: user.NameLastName,
                Year: DateTime.Now.Year,
                Companies: companiesDto,
                Company: companiesDto[0]
                );

            return response;
        }
    }
}
