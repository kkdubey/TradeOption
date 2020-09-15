using BLL.Implementations;
using BLL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace TraderApi.Infrastructure.Extensions
{

    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Extension Method to add Database and create Migration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<ApplicationDbContext>(options => options
                    .UseSqlServer(configuration.GetDefaultConnectionString(), b => b.MigrationsAssembly("TraderApi")));

        /// <summary>
        /// Extension method to add Swagger configuration
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwagger(this IServiceCollection services)
            => services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Trader API",
                        Version = "v1"
                    });
            });

        /// <summary>
        /// Extension method to define DI
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
            => services
            // Repositories
            .AddScoped<IUnitOfWork, UnitOfWork>()
            // Business 
            .AddScoped<IStockManager, StockManager>()
            .AddScoped<IStockTransactionManager, StockTransactionManager>()
            .AddScoped<IUserManager, UserManager>()
            // DB Creation and Seeding
            .AddTransient<IDatabaseInitializer, DatabaseInitializer>();
    }

}
