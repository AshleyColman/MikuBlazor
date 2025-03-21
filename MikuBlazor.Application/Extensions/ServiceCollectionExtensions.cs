using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MikuBlazor.Application.AutoMapper;

namespace MikuBlazor.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        services.AddAutoMapper(options => options.AddProfile<AppProfile>());
        
        return services;
    }
    
}