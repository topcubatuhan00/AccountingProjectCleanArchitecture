﻿using OnlineMuhasebeServer.Domain.Abstractions;

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

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

    }
}
