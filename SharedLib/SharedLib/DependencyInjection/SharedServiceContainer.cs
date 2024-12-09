
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SharedLib.DependencyInjection
{
    public static class SharedServiceContainer
        
    {
        public static IServiceCollection AddSharedServices<TContext>(this IServiceCollection services, IConfiguration config) where TContext: DbContext
        {
            try
            {
                services.AddDbContext<TContext>(options =>
                {
                    options.UseSqlServer(config.GetConnectionString("ProjectsDB"),
                    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
                });
                return services;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
