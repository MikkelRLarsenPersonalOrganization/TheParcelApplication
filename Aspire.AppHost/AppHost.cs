using System;


namespace Aspire.AppHost
{
    public class AppHost
    {
        public static void Main(string[] args)
        {
            var builder = DistributedApplication.CreateBuilder(args);

            var postgres = builder.AddPostgres("postgres")
                .WithLifetime(ContainerLifetime.Persistent)
                .WithPgAdmin();

            var parcelDb = postgres.AddDatabase("parceldb");

            var parcelService = builder.AddProject<Projects.ParcelService_Api>("parcelService")
                .WithReference(parcelDb)
                .WaitFor(parcelDb);

            builder.Build().Run();
        }
    }
}