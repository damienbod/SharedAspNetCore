using Microsoft.Extensions.DependencyInjection;
using SharedRazorPages.Services;

namespace SharedRazorPages
{
    public static class SharedRazorPagesExtensions
    {
    
        public static IServiceCollection AddSharedRazorPagesServices(this IServiceCollection services)
        {
            services.AddScoped<SomeSharedPageService>();

            return services;
        }
    }  
}
