using Azure.Core;
using MediatR;
using OnlineMuhasebeServer.Domain.AppEntities;
using System.Threading;

namespace OnlineMuhasebeServer.Application.Services.AppService;

public interface IMainRoleService
{
    Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken);
    Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);
    Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken);

    IQueryable<MainRole> GetAll();
    Task RemoveByIdAsync(string id);

    Task<MainRole> GetById(string Id);
    Task UpdateAsync(MainRole mainRole);
}
