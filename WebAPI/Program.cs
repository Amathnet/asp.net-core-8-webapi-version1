using NLog;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager
    .Setup()
    .LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureSqlContext(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.MapGet("/", () => "Hello World!");

app.Run();
