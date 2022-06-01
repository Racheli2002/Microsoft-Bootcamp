using boot_camp2;
using Dal;
using Serilog;
using Services;

var builder = WebApplication.CreateBuilder(args);
//var logger = new LoggerConfiguration()
//  .ReadFrom.Configuration(builder.Configuration)
//  .Enrich.FromLogContext()
//  .CreateLogger();

builder.Host.UseSerilog((hostContext, services, configuration) => {
configuration.WriteTo.File("C:\\Users\\WIN10\\source\\repos\\r.txt");
});
//builder.Logging.ClearProviders();
//builder.Logging.AddSerilog(logger);
builder.Services.AddRazorPages();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationData, LocationData>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
app.UseErrorMiddleware();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
public partial class Program { }
