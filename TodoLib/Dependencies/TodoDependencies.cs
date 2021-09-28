using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
//using TodoLib.Services;

namespace TodoLib.Dependencies
{
    public static class TodoDependencies
    {
        public static IServiceCollection AddTodoServices(this IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
            services.AddSingleton<AppData>(/*(svp) => {
                //use this to load saved data
                var ast = new AppState(new System.Collections.Generic.List<ToDoItem>());

                return ast;
            }*/);


            return services;
        }
    }
}
