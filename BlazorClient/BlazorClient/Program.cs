using BlazorClient;
using Blazored.LocalStorage;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Havit.Blazor.Components.Web;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSweetAlert2();
builder.Services.AddHxServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://younesabady.azurewebsites.net/api/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7007/api/") });
builder.Services.AddBlazoredLocalStorage();


await builder.Build().RunAsync();
