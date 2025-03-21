using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;
using MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEntityFrameworkServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextFactory<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("AppDbConnectionString"))
                   .EnableSensitiveDataLogging()
                   .LogTo(Console.Write);
        });

        // services.TryAddScoped<IAnimeRepository, AnimeRepository>();
        
        return services;
    }
}