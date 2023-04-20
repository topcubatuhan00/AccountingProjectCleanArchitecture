using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandHandler : ICommandHandler<RemoveByIdUserAndCompanyRLCommand, RemoveByIdUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _service;

        public RemoveByIdUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdUserAndCompanyRLCommandResponse> Handle(RemoveByIdUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            UserAndCompanyRelationship entity = await _service.GetByIdAsync(request.id);
            if (entity == null) throw new Exception("silmek istediniz ilişki bulunamadı");

            await _service.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
