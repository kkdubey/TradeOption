using Microsoft.Extensions.Configuration;

namespace TraderApi.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Method to get connection string
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static string GetDefaultConnectionString(this IConfiguration configuration)
            => configuration.GetConnectionString("DefaultConnection");
    }
}
