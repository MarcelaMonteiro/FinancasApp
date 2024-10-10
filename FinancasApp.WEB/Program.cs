using Blazored.LocalStorage;
using FinancasApp.WEB;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient 
{ BaseAddress = new Uri("http://localhost:5271") });

await builder.Build().RunAsync();
