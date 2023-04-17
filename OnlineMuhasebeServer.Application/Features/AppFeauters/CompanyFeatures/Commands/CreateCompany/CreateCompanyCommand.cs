using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
        string Name,
        string ServerName,
        string DatabaseName,
        string UserId,
        string Password
        ) : ICommand<CreateCompanyCommandResponse>;

}
