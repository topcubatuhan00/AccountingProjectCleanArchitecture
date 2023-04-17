using Microsoft.AspNetCore.Identity;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.WebApi.Configurations;
using OnlineMuhasebeServer.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionMiddleWare();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "batu",
            Email = "topcubatuhan00@gmail.com",
            Id = Guid.NewGuid().ToString(),
            NameLastName = "batuhan topcu"
        }, "Password12*").Wait();
    }
}

app.Run();
