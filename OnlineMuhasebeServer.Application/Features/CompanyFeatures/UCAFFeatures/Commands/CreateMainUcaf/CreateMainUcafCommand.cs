using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateMainUcaf;

public sealed record CreateMainUcafCommand(
        string companyId  
    ) : ICommand<CreateMainUcafCommandResponse>;
