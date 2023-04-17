﻿using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesResponse
    {
        public IList<AppRole> Roles { get; set; }
    }
}
