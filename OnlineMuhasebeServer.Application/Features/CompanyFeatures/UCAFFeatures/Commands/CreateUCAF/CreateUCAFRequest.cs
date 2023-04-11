using MediatR;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFRequest : IRequest<CreateUCAFResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; } // main group - sub group  - ... 
        public string CompanyId { get; set; }
    }
}
