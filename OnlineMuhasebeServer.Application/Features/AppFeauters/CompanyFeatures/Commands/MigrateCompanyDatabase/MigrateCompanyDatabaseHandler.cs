using MediatR;
using OnlineMuhasebeServer.Application.Services.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabaseHandler : IRequestHandler<MigrateCompanyDatabaseRequest, MigrateCompanyDatabaseResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateCompanyDatabaseHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateCompanyDatabaseResponse> Handle(MigrateCompanyDatabaseRequest request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabases();
            return new();
        }
    }
}
