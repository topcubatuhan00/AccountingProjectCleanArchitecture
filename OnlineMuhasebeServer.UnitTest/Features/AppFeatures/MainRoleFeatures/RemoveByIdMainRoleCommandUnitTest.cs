using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.RemoveMainRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures
{
    public class RemoveByIdMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _service;

        public RemoveByIdMainRoleCommandUnitTest()
        {
            _service = new();
        }


        [Fact]
        public async Task RemoveByIdMainRoleShouldNotBeNull()
        {
            var command = new RemoveByIdMainRoleCommand(
                    Id: "3fad8764-deaf-495b-ae78-7d0b883657c9"
                );

            var handler = new RemoveByIdMainRoleCommandHandler(_service.Object);
            RemoveByIdMainRoleCommandResponse response = await handler.Handle(command,default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
