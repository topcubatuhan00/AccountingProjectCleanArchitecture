using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.RoleDelete;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public DeleteRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _ = _roleServiceMock.Setup(
                x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(
                    Id: "8a0a9c99-2606-4501-9697-9129604145c9"
                );
            _ = _roleServiceMock.Setup(
               x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
            var handler = new DeleteRoleCommandHandler(_roleServiceMock.Object);
            DeleteRoleCommandResponse response = await handler.Handle(command,default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
