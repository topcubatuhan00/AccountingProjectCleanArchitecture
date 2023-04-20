using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationShipRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;

namespace OnlineMuhasebeServer.Persistance.Services.AppService
{
    public sealed class MainRoleAndUserRelationshipService : IMainRoleAndUserRelationshipService
    {

        private readonly IMainRoleAndUserRelationShipCommandRepository _commandRepository;
        private readonly IMainRoleAndUserRelationShipQueryRepository _queryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleAndUserRelationshipService(IAppUnitOfWork unitOfWork, IMainRoleAndUserRelationShipQueryRepository queryRepository, IMainRoleAndUserRelationShipCommandRepository commandRepository)
        {
            _unitOfWork = unitOfWork;
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
        }

        public async Task CrateAsync(MainRoleAndUserRelationship mainRoleAndUserRelationship, CancellationToken cancellationToken)
        {
            await _commandRepository.AddAsync(mainRoleAndUserRelationship, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<MainRoleAndUserRelationship> GetAll()
        {
            return _queryRepository.GetAll();
        }

        public async Task<MainRoleAndUserRelationship> GetByIdAsync(string id, bool isTracking)
        {
            MainRoleAndUserRelationship entity = await _queryRepository.GetById(id, isTracking);
            return entity;
        }

        public async Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string companyId, string mainRoleId, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetFirstByExpression(p => p.MainRoleId == mainRoleId && p.UserId == userId && p.CompanyId == companyId ,cancellationToken);
        }

        public async Task<MainRoleAndUserRelationship> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            return await _queryRepository.GetFirstByExpression(p => p.UserId == userId && p.CompanyId == companyId, default);
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
