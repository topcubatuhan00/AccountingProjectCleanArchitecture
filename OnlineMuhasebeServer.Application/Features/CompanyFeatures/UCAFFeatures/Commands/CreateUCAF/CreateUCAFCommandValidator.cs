using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

public sealed class CreateUCAFCommandValidator : AbstractValidator<CreateUCAFCommand>
{
    public CreateUCAFCommandValidator()
    {
        RuleFor(p => p.Code).NotNull().WithMessage("Hesap Planı Kodu Boş Olamaz");
        RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap Planı Kodu Boş Olamaz");
        //RuleFor(p => p.Code).MinimumLength(4).WithMessage("Hesap Planı En Az 4 Karakter Olmalı");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Hesap Planı Adı Boş Olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Hesap Planı Adı Boş Olamaz");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket Bilgisi Boş Olamaz");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket Bilgisi Boş Olamaz");
        RuleFor(p => p.Type).NotNull().WithMessage("Hesap Planı Tipi Bilgisi Boş Olamaz");
        RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap Planı Tipi Bilgisi Boş Olamaz");
        RuleFor(p => p.Type).MaximumLength(1).WithMessage("Hesap Planı Tipi 1 Karakter Olmalıdır");
    }
}
