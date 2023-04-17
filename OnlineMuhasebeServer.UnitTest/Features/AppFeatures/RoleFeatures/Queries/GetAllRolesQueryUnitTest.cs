using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Queries.GetAllRoles;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures.Queries
{
    public sealed class GetAllRolesQueryUnitTest
    {
        private readonly Mock<IRoleService> _roleService;

        public GetAllRolesQueryUnitTest()
        {
            _roleService = new();
        }

        [Fact]
        public async Task GetAllRolesQueryResponseShouldNotBeNull()
        {
            _roleService.Setup(x => x.GetAllRolesAsync()).ReturnsAsync(new List<AppRole>());

        }
    }
}
