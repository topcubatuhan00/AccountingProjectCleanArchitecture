using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures
{
    public sealed class CreateUCAFCommandUnitTest
    {
        private readonly Mock<IUCAFService> _service;

        public CreateUCAFCommandUnitTest()
        {
            _service = new();
        }

        [Fact]
        public async Task UCAFShouldBeNull()
        {
            UniformChartOfAccount ucaf = await _service.Object.GetByCode("100.01.001",default);
            ucaf.ShouldBeNull();
        }

        [Fact]
        public async Task CreateUCAFCommandResponseShouldNotBeNull()
        {
            var command = new CreateUCAFCommand(
                    Code: "100.01.001",
                    Name: "TL Kasa",
                    Type: "M",
                    CompanyId: "8a0a9c99-2606-4501-9697-9129604145c9"
                );

            var handler = new CreateUCAFCommandHandler(_service.Object);
            CreateUCAFCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
