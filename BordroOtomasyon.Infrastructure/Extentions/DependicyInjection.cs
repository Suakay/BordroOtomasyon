
using BordroOtomasyon.Domain.Entities;
using BordroOtomasyon.Infrastructure.Context;
using BordroOtomasyon.Infrastructure.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Extentions
{
   public static class DependicyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseLazyLoadingProxies();
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

           AdminSeed.SeedAsync(configuration).GetAwaiter().GetResult();//Migrationda burası kapatılmalı.
            

            return services;
        }
    }
}
