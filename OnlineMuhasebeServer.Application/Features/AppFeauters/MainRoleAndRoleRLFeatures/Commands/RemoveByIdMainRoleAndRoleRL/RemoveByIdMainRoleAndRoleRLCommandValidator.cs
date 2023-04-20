using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandValidator : AbstractValidator<RemoveByIdMainRoleAndRoleRLCommand>
    {
        public RemoveByIdMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("Id boş olamaz");
            RuleFor(p => p.id).NotNull().WithMessage("Id boş olamaz");
        }
    }
}
