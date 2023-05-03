using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _uCAFService;

        public CreateUCAFCommandHandler(IUCAFService uCAFService)
        {
            _uCAFService = uCAFService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {

            if (request.Type != "G" && request.Type != "M") throw new Exception("Hesap planı türü grup ya da muavin olmalıdır");

            //UniformChartOfAccount ucaf = await _uCAFService.GetByCode(request.Code, cancellationToken);
            //if (ucaf != null) throw new Exception("Hesap planı zaten kayıtlı");
            await _uCAFService.CreateUCAFAsync(request, cancellationToken);
            return new();
        }
    }
}
