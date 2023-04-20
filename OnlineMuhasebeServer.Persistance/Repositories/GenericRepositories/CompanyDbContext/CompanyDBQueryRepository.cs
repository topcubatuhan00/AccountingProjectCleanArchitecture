using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using System.Linq.Expressions;

namespace OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.CompanyDbContext
{
    public class CompanyDBQueryRepository<T> : ICompanyDBQueryRepository<T> where T : Entity
    {
        private static readonly Func<Context.CompanyDbContext, string, bool, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((Context.CompanyDbContext context, string id, bool isTracking) =>
            isTracking == true ? context.Set<T>().FirstOrDefault(p => p.Id == id) :
            context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<Context.CompanyDbContext, bool, Task<T>> GetFirstCompiled =
            EF.CompileAsyncQuery((Context.CompanyDbContext context, bool isTracking) =>
            isTracking == true ? context.Set<T>().FirstOrDefault() :
            context.Set<T>().AsNoTracking().FirstOrDefault());

        private Context.CompanyDbContext _companyDbContext;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _companyDbContext = (Context.CompanyDbContext)dbContext;
            Entity = _companyDbContext.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var result = Entity.AsQueryable();
            if (!isTracking)
                result = result.AsNoTracking();
            return result;
        }

        public async Task<T> GetById(string id, bool isTracking = true)
        {
            return await GetByIdCompiled(_companyDbContext, id, isTracking);
        }

        public async Task<T> GetFirst(bool isTracking = true)
        {
            return await GetFirstCompiled(_companyDbContext, isTracking);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default, bool isTracking = true)
        {
            T entity = null;
            if (!isTracking)
                entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync();
            else
                entity = await Entity.Where(expression).FirstOrDefaultAsync();
            return entity;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if (!isTracking)
                result = result.AsNoTracking();
            return result;
        }
    }
}
