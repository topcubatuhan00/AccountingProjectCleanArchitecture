using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Services.CompanyService
{
    public interface IUCAFService
    {
        Task CreateUCAFAsync(CreateUCAFCommand request, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetByCode(string code, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetById(string companyId, string id, CancellationToken cancellationToken);
        Task RemoveById(string companyId, string id, CancellationToken cancellationToken);
        Task CreateMainUcafsToCompanyAsync(string companyId, CancellationToken cancellationToken);
        Task<IList<UniformChartOfAccount>> GetAllAsync(string companyId);
        Task<bool> CheckRemoveByIdUCAFAvailable(string companyId, string id);
        Task UpdateAsync(UniformChartOfAccount account, string companyId);
    }
}
