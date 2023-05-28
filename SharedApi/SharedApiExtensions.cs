using Microsoft.Extensions.DependencyInjection;
using SharedApi.Services;

namespace SharedApi;

public static class SharedApiExtensions
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        services.AddScoped<SomeSharedService>();
        return services;
    }
}  
