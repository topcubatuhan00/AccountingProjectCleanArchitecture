using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Persistance;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Persistance.Services.AppService;
using OnlineMuhasebeServer.Persistance.Services.CompanyService;
using OnlineMuhasebeServer.Persistance.UnitOfWorks;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context & UnitOfWork
            services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<IRoleService, RoleService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();

            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            #endregion

        }
    }
}
