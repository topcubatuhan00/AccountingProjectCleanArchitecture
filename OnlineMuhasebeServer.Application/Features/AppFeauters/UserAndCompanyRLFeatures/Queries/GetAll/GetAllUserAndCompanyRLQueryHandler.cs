using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Queries.GetAll
{
    public sealed class GetAllUserAndCompanyRLQueryHandler : IQueryHandler<GetAllUserAndCompanyRLQuery, GetAllUserAndCompanyRLQueryResponse>
    {
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;

        public GetAllUserAndCompanyRLQueryHandler(IUserAndCompanyRelationshipService userAndCompanyRelationshipService)
        {
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
        }

        public async Task<GetAllUserAndCompanyRLQueryResponse> Handle(GetAllUserAndCompanyRLQuery request, CancellationToken cancellationToken)
        {
            return new(await _userAndCompanyRelationshipService
                .GetAll()
                .Include("AppUser")
                .Include("Company")
                .ToListAsync()
                );
        }
    }
}
