using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;

namespace OnlineMuhasebeServer.Persistance.Services.AppService
{
    public sealed class MainRoleAndRoleRelationshipService : IMainRoleAndRoleRelationshipService
    {
        private readonly IMainRoleAndRoleRelationshipCommandRepository _commandRepository;
        private readonly IMainRoleAndRoleRelationshipQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleAndRoleRelationshipService(IAppUnitOfWork unitOfWork, IMapper mapper, IMainRoleAndRoleRelationshipQueryRepository queryRepository, IMainRoleAndRoleRelationshipCommandRepository commandRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
        }

        public async Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken)
        {
            //MainRoleAndRoleRelationship mr = _mapper.Map<MainRoleAndRoleRelationship>(mainRoleAndRoleRelationship);
            //mainRoleAndRoleRelationship.Id = Guid.NewGuid().ToString();
            await _commandRepository.AddAsync(mainRoleAndRoleRelationship, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<MainRoleAndRoleRelationship> GetAll()
        {
            return _queryRepository.GetAll();
        }

        public async Task<MainRoleAndRoleRelationship> GetByIdAsync(string id)
        {
            return await _queryRepository.GetById(id);
        }

        public async Task<IList<MainRoleAndRoleRelationship>> GetListByMainRoleIdForGetRolesAsync(string id)
        {
            return await _queryRepository.GetWhere(p => p.MainRoleId == id).Include("AppRole").ToListAsync();
        }

        public async Task<MainRoleAndRoleRelationship> GetRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default)
        {
            return await _queryRepository.GetFirstByExpression(p => p.RoleId == roleId && p.MainRoleId == mainRoleId,cancellationToken);
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship)
        {
            _commandRepository.Update(mainRoleAndRoleRelationship);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
