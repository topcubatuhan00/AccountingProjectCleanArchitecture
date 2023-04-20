using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.Create
{
    public sealed class CreateMainRoleAndUserRLCommandValidator : AbstractValidator<CreateMainRoleAndUserRLCommand>
    {
        public CreateMainRoleAndUserRLCommandValidator()
        {
            RuleFor(p => p.userId).NotNull().WithMessage("User Id Boş Olamaz");
            RuleFor(p => p.userId).NotEmpty().WithMessage("User Id Boş Olamaz");
            RuleFor(p => p.companyId).NotNull().WithMessage("Şirket Id Boş Olamaz");
            RuleFor(p => p.companyId).NotEmpty().WithMessage("Şirket Id Boş Olamaz");
            RuleFor(p => p.mainRoleId).NotNull().WithMessage("Rol Id Boş Olamaz");
            RuleFor(p => p.mainRoleId).NotEmpty().WithMessage("Rol Id Boş Olamaz");
        }
    }
}
