using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole;

public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public CreateRoleCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().WithMessage("Rol Kodu Boş Olamaz");
        RuleFor(p => p.Code).NotNull().WithMessage("Rol Kodu Boş Olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Rol Adı Boş Olamaz");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Rol Adı Boş Olamaz");
    }
}
