using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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


            var configuration = new ConfigurationBuilder()
 
            .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsetting.json")
                 .Build();
            var serviceColection = new ServiceCollection();
            ConfigureServices(serviceColection, configuration);

            serviceProvider = serviceColection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<Login>();
            services.AddInfrastructureServices(configuration);



        }



    }
}