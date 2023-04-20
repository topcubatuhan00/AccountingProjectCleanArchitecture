using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRLCommandValidator : AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRLCommandValidator()
        {
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Rol seçilmelidir!");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Rol seçilmelidir!");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana Rol seçilmelidir!");
            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana Rol seçilmelidir!");
        }
    }
}
