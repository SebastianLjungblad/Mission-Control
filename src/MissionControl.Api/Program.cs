using MissionControl.Core.Services;
using MissionControl.Core.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<ISatelliteService, SatelliteService>();

builder.Services.AddOpenApi();

builder.Services.AddControllers();

builder.Services.AddHttpClient<CelesTrakClient>();

builder.Services.AddSingleton<ISatelliteService, SatelliteService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();