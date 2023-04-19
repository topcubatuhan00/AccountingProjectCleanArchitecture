using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.UpdateRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures
{
    public sealed class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;

        public UpdateRoleCommandUnitTest()
        {
            _roleService = new();
        }

        [Fact]
        public async Task AppRoleShoudNotBeNull()
        {
            _ = _roleService.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task AppRoleCodeShouldBeUnique()
        {
            AppRole checkRoleCode = await _roleService.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();
        }

        [Fact]
        public async Task UpdateCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                   Id: "8a0a9c99-2606-4501-9697-9129604145c9",
                   Code: "UCAF.Create",
                   Name: "test update"
                );

            _ = _roleService.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());

            var handler = new UpdateRoleCommandHandler(_roleService.Object);
            UpdateRoleCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}

