using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.UpdateUCAF;

public sealed class UpdateUCAFCommandHandler : ICommandHandler<UpdateUCAFCommand, UpdateUCAFCommandResponse>
{
    private readonly IUCAFService _service;

    public UpdateUCAFCommandHandler(IUCAFService service)
    {
        _service = service;
    }

    public async Task<UpdateUCAFCommandResponse> Handle(UpdateUCAFCommand request, CancellationToken cancellationToken)
    {
        UniformChartOfAccount ucaf = await _service.GetById(request.CompanyId,request.Id,cancellationToken);
        if (ucaf == null) throw new Exception("Silmek istediğiniz UCAF Bulunamadı");

        if (request.Type != "G" && request.Type != "M") throw new Exception("Hesap planı türü grup ya da muavin olmalıdır");

        ucaf.Type = request.Type == "G" ? 'G' : 'M';
        ucaf.Code = request.Code;
        ucaf.Name = request.Name;

        await _service.UpdateAsync(ucaf,request.CompanyId);
        return new();
    }
}
