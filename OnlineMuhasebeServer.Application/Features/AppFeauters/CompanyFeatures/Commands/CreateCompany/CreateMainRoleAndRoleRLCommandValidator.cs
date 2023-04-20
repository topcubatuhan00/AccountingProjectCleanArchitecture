using FluentValidation;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateMainRoleAndRoleRLCommandValidator : AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana Rol Seçilmelidir.");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana Rol Seçilmelidir.");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Rol Seçilmelidir.");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Rol Seçilmelidir.");
        }
    }
}
