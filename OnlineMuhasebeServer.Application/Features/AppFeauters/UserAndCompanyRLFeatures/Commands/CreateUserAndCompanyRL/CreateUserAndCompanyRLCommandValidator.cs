using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed class CreateUserAndCompanyRLCommandValidator : AbstractValidator<CreateUserAndCompanyRLCommand>
    {
        public CreateUserAndCompanyRLCommandValidator()
        {
            RuleFor(p => p.AppUserId).NotNull().WithMessage("Kullanıcı id zorunlu");
            RuleFor(p => p.AppUserId).NotEmpty().WithMessage("Kullanıcı id zorunlu");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("CompanyId zorunlu");
            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("CompanyId zorunlu");
        }
    }
}
