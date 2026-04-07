using Shared;
using ParcelService.InversionOfControl;

namespace ParcelService.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers().AddDapr();

        builder.AddServiceDefaults();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.RegisterServices(builder.Configuration);

        var app = builder.Build();

        app.SetupDatabaseOnColdStart();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
