using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.RemoveByIdUCAF;

public sealed class RemoveByIdUCAFCommandValidator : AbstractValidator<RemoveByIdUCAFCommand>
{
    public RemoveByIdUCAFCommandValidator()
    {
        RuleFor(p => p.Id).NotNull().WithMessage("Id Boş Olamaz");
        RuleFor(p => p.Id).NotEmpty().WithMessage("Id Boş Olamaz");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket Id Boş Olamaz");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket Id Boş Olamaz");
    }
}
