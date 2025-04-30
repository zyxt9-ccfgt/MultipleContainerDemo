using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SampleContainerization.Application.Common.Behaviours;
using System.Reflection;

namespace SampleContainerization.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(ctg =>
            {
                ctg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                // validation
                ctg.AddBehavior(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,>));
            });

            return services;
        }
    }
}
