using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.UpdateMainRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures
{
    public sealed class UpdateMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _service;

        public UpdateMainRoleCommandUnitTest()
        {
            _service = new();
        }

        [Fact]
        public async Task MainRoleShouldNotBeNull()
        {
            _service.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new MainRole());
        }

        [Fact]
        public async Task UpdateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateMainRoleCommand(
                    Id: "3fad8764-deaf-495b-ae78-7d0b883657c9",
                    Title: "Admin"
                );
            _service.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new MainRole());
            var handler = new UpdateMainRoleCommandHandler(_service.Object);
            UpdateMainRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
