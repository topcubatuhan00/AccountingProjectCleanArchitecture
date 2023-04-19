using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Queries.GetAllMainRole;

public sealed record  GetAllMainRoleResponse(
        IList<MainRole> MainRoles
    );
