using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdMainRoleAndUserRLCommandValidator : AbstractValidator<RemoveByIdMainRoleAndUserRLCommand>
    {
        public RemoveByIdMainRoleAndUserRLCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id Zorunlu");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id Zorunlu");
        }
    }
}
