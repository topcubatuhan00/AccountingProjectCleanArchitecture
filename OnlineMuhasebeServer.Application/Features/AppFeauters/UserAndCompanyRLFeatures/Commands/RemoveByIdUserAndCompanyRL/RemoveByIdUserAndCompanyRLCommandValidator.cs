using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandValidator : AbstractValidator<RemoveByIdUserAndCompanyRLCommand>
    {
        public RemoveByIdUserAndCompanyRLCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id boş olamaz");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id boş olamaz");
        }
    }
}
