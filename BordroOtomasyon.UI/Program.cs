using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using BordroOtomasyon.Infrastructure.Extentions;
namespace BordroOtomasyon.UI
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Json")
            .Build();
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
       private static void ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            services.AddTransient<Form1>();  
            services.AddInfrastructureServices(configuration);

        }
        
       
       
    }
}