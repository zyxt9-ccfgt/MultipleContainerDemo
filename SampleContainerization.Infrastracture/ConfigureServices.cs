using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleContainerization.Domain.Interface;
using SampleContainerization.Infrastructure.Data;
using SampleContainerization.Infrastructure.Repository;
using System.Reflection;

namespace SampleContainerization.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
                                                                   IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BlogDbContext") ??
                    throw new InvalidOperationException("Connection string 'BlogDbContext not found.'"));
            });

            services.AddTransient<IBlogRepository, BlogRepository>();

            return services;
        }
    }
}
