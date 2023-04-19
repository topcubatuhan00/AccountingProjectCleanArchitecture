using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeauters.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed class UpdateMainRoleCommandHandler : ICommandHandler<UpdateMainRoleCommand, UpdateMainRoleCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public UpdateMainRoleCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<UpdateMainRoleCommandResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole mainRole = await _mainRoleService.GetById(request.Id);

            if (mainRole == null) throw new Exception("Bu ana rol bulunamadı");
            if (mainRole.Title == request.Title) throw new Exception("güncellemek istediğiniz ad ile eski ad aynı");
            if (mainRole.Title != request.Title)
            {
                MainRole checMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.CompanyId, cancellationToken);
                if (checMainRoleTitle != null) throw new Exception("bu rol adı daha önce kullanılmış");
            }

            mainRole.Title = request.Title;
            await _mainRoleService.UpdateAsync(mainRole);
            return new();

        }
    }
}
