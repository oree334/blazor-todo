using Microsoft.Extensions.DependencyInjection;
using TodoLib.Services;

namespace TodoLib.Dependencies
{
    public static class TodoDependencies
    {
        public static IServiceCollection AddTodoServices(this IServiceCollection services)
        {
            services.AddScoped<ToastService>();
            return services;
        }
    }
}
