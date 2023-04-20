using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed record CreateUserAndCompanyRLCommand(
            string AppUserId,
            string CompanyId
        ) : ICommand<CreateUserAndCompanyRLCommandResponse>;
}
