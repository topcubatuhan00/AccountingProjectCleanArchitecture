using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.CreateMainRole;

public sealed record CreateMainRoleCommand(
        string Title,
        string CompanyId = null
    ) : ICommand<CreateMainRoleCommandResponse>;
