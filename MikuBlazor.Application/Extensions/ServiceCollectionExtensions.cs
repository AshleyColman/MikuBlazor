using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MikuBlazor.Application.AutoMapper;
using MikuBlazor.Web.Middleware;

namespace MikuBlazor.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(currentAssembly);
            options.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
        });

        services.AddAutoMapper(options => options.AddProfile<AppProfile>());

        services.AddValidatorsFromAssembly(currentAssembly);
        
        return services;
    }
    
}