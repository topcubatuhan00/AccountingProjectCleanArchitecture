using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabaseResponse
    {
        public string Message { get; set; } = "Şirketlerin database bilgileri migrate edildi.";
    }
}
