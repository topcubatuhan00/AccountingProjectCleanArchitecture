﻿using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories;
using OnlineMuhasebeServer.Persistance.Context;
using System.Linq.Expressions;

namespace OnlineMuhasebeServer.Persistance.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : Entity
    {
        private static readonly Func<CompanyDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));
        
        private static readonly Func<CompanyDbContext, Task<T>> GetFirstCompiled =
            EF.CompileAsyncQuery((CompanyDbContext context) =>
            context.Set<T>().FirstOrDefault());

        private static readonly Func<CompanyDbContext, Expression<Func<T, bool>>, Task<T>> GetFirstByExpressionCompiled =
            EF.CompileAsyncQuery((CompanyDbContext context, Expression<Func<T, bool>> expression) =>
            context.Set<T>().FirstOrDefault(expression));

        private CompanyDbContext _companyDbContext;

        public DbSet<T> Entity { get; set; }

        public void CreateDbContextInstance(DbContext dbContext)
        {
            _companyDbContext = (CompanyDbContext)dbContext;
            Entity = _companyDbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetById(string id)
        {
            return await GetByIdCompiled(_companyDbContext, id);
        }

        public async Task<T> GetFirst()
        {
            return await GetFirstCompiled(_companyDbContext);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await GetFirstByExpressionCompiled(_companyDbContext, expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
