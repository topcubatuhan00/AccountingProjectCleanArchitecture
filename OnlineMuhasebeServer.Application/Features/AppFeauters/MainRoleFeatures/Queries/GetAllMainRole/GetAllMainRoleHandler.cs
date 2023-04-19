using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Queries.GetAllMainRole
{
    public sealed class GetAllMainRoleHandler : IQueryHandler<GetAllMainRoleQuery, GetAllMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public GetAllMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<GetAllMainRoleResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
        {
            var result = _mainRoleService.GetAll();
            return new(await result.ToListAsync());
        }
    }
}
