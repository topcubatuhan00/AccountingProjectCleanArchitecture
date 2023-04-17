using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.UpdateRole;

public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
{
    public UpdateRoleCommandValidator()
    {

        RuleFor(p => p.Id).NotEmpty().WithMessage("Rol Id Boş Olamaz");
        RuleFor(p => p.Id).NotEmpty().WithMessage("Rol Id Boş Olamaz");
        RuleFor(p => p.Code).NotEmpty().WithMessage("Rol Kodu Boş Olamaz");
        RuleFor(p => p.Code).NotNull().WithMessage("Rol Kodu Boş Olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Rol Adı Boş Olamaz");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Rol Adı Boş Olamaz");
    }
}
