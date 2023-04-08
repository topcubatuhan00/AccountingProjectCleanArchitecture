﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance.Services.AppService
{
    public sealed class CompanyService : ICompanyService
    {
        private static readonly Func<AppDbContext, string , Task<Company?>> GetCompanyByNameCompiled = 
            EF.CompileAsyncQuery((AppDbContext context, string name)=>
            context.Set<Company>().FirstOrDefault(p => p.Name == name));
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CompanyService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task CreateCompany(CreateCompanyRequest request)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            await _appDbContext.Set<Company>().AddAsync(company);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Company?> GetCompanyByName(string name)
        {
            return await GetCompanyByNameCompiled(_appDbContext,name);
            
        }

        public async Task MigrateCompanyDatabases()
        {
            var companies = await _appDbContext.Set<Company>().ToListAsync();
            foreach (var item in companies)
            {
                var db = new CompanyDbContext(item);
                db.Database.Migrate();  
                
            }
        }
    }
}
