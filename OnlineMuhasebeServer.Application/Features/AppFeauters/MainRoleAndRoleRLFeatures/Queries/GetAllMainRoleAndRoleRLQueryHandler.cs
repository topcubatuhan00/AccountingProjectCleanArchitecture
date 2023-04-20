using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleAndRoleRLFeatures.Queries
{
    public sealed class GetAllMainRoleAndRoleRLQueryHandler : IQueryHandler<GetAllMainRoleAndRoleRLQuery, GetAllMainRoleAndRoleRLQueryResponse>
    {

        private readonly IMainRoleAndRoleRelationshipService _relationshipService;

        public GetAllMainRoleAndRoleRLQueryHandler(IMainRoleAndRoleRelationshipService relationshipService)
        {
            _relationshipService = relationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRLQueryResponse> Handle(GetAllMainRoleAndRoleRLQuery request, CancellationToken cancellationToken)
        {
            return new(await _relationshipService.
                GetAll()
                .Include("AppRole")
                .Include("MainRole")
                .ToListAsync());
        }
    }
}
