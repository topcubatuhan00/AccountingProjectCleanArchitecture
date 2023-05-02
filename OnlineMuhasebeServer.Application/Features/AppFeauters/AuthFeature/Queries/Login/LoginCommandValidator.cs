using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AuthFeature.Queries.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.EmailOrUserName).NotEmpty().WithMessage("Mail yada kullanıcı adı yazmalısınız");
            RuleFor(p => p.EmailOrUserName).NotNull().WithMessage("Mail yada kullanıcı adı yazmalısınız");
            RuleFor(p => p.EmailOrUserName).MinimumLength(4).WithMessage("Mail yada kullanıcı adı en az 4 karakter olmalı");
            RuleFor(p => p.Password).NotEmpty().WithMessage("şifre yazmalısınız");
            RuleFor(p => p.Password).MinimumLength(6).WithMessage("şifre en az 6 karakter olmalı");
        }
    }
}
