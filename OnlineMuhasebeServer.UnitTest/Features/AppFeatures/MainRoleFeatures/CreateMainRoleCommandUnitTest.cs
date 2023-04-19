using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateMainRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures;

public sealed class CreateMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _service;

    public CreateMainRoleCommandUnitTest()
    {
        _service = new();
    }

    [Fact]
    public async Task MainRoleShouldBeNull()
    {
        MainRole mainRole = await _service.Object.GetByTitleAndCompanyId(
            "Admin",
            "3fad8764-deaf-495b-ae78-7d0b883657c9",
            default);
        mainRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateMainRoleCommandResponseShouldNotBeNull()
    {
        var command = new CreateMainRoleCommand(
                Title: "Admin",
                CompanyId: "3fad8764-deaf-495b-ae78-7d0b883657c9"
            );

        var handler = new CreateMainRoleCommandHandler(_service.Object);
        CreateMainRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
