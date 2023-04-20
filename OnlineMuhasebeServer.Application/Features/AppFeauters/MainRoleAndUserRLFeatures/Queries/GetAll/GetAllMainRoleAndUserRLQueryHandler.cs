using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndUserRLFeatures.Queries.GetAll
{
    public sealed class GetAllMainRoleAndUserRLQueryHandler : IQueryHandler<GetAllMainRoleAndUserRLQuery, GetAllMainRoleAndUserRLQueryResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;

        public GetAllMainRoleAndUserRLQueryHandler(IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService)
        {
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
        }

        public async Task<GetAllMainRoleAndUserRLQueryResponse> Handle(GetAllMainRoleAndUserRLQuery request, CancellationToken cancellationToken)
        {
            return new(await _mainRoleAndUserRelationshipService.
                GetAll()
                .Include("AppUser")
                .Include("MainRole")
                .Include("Company")
                .ToListAsync());
        }
    }
}
