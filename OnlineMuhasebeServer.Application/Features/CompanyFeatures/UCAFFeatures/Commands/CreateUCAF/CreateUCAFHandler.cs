using MediatR;
using OnlineMuhasebeServer.Application.Services.CompanyService;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public class CreateUCAFHandler : IRequestHandler<CreateUCAFRequest, CreateUCAFResponse>
    {
        private readonly IUCAFService _uCAFService;

        public CreateUCAFHandler(IUCAFService uCAFService)
        {
            _uCAFService = uCAFService;
        }

        public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
        {
            await _uCAFService.CreateUCAFAsync(request);
            return new();
        }
    }
}
