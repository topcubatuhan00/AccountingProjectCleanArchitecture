using FluentValidation;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.RoleDelete;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.DeleteRole;

public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
{
    public DeleteRoleCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty().WithMessage("Rol Id Boş Olamaz");
        RuleFor(p => p.Id).NotNull().WithMessage("Rol Id Boş Olamaz");
    }
}
