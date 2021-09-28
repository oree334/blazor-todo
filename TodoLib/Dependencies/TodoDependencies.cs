using Microsoft.Extensions.DependencyInjection;
//using TodoLib.Services;

namespace TodoLib.Dependencies
{
    public static class TodoDependencies
    {
        public static IServiceCollection AddTodoServices(this IServiceCollection services)
        {
            services
                .AddSingleton<AppState>((svp) => {
                    //use this to load saved data

                    return new AppState(new System.Collections.Generic.List<ToDoItem>());
                });
            return services;
        }
    }
}
