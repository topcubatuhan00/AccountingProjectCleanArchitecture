namespace OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed record MigrateCompanyDatabaseCommandResponse(
        string Message = "Şirketlerin database bilgileri migrate edildi.");

}
