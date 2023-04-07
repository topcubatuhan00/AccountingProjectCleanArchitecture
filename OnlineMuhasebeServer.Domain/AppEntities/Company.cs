using OnlineMuhasebeServer.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Domain.AppEntities
{
    public sealed class Company : Entity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartment { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
