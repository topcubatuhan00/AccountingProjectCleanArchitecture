﻿using OnlineMuhasebeServer.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Services.AppService
{
    public interface IUserAndCompanyRelationshipService
    {
        Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<UserAndCompanyRelationship> GetByIdAsync(string id);
        Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken);
        Task<IList<UserAndCompanyRelationship>> GetListByUserId(string userId);
        IQueryable<UserAndCompanyRelationship> GetAll();
    }
}
