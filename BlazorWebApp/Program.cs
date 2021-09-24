using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoLib.Dependencies;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<TodoLib.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddTodoServices();

await builder.Build().RunAsync();
