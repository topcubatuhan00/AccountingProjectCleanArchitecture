using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed record  RemoveByIdUserAndCompanyRLCommand(
            string id    
        ) : ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;
}
