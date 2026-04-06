using System;


namespace Aspire.AppHost
{
    public class AppHost
    {
        public static void Main(string[] args)
        {
            var builder = DistributedApplication.CreateBuilder(args);

            //builder.AddProject<Projects.Template_Api>("template-api");

            builder.Build().Run();

        }
    }
}