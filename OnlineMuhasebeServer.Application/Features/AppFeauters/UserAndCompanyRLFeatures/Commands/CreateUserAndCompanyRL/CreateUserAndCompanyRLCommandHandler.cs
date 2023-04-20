using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed class CreateUserAndCompanyRLCommandHandler : ICommandHandler<CreateUserAndCompanyRLCommand, CreateUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _service;

        public CreateUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService service)
        {
            _service = service;
        }
        public async Task<CreateUserAndCompanyRLCommandResponse> Handle(CreateUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            UserAndCompanyRelationship entity = await _service.GetByUserIdAndCompanyId(request.AppUserId, request.CompanyId, cancellationToken);

            if (entity != null) throw new Exception("Bu kullanıcı daha önce bu şirkete kayıt edilmiş");

            UserAndCompanyRelationship userAndCompanyRelationship = new(
                Guid.NewGuid().ToString(),
                request.AppUserId,
                request.CompanyId);

            await _service.CreateAsync(userAndCompanyRelationship, cancellationToken);
            return new();
        }
    }
}
