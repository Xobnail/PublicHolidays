using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PublicHolidays.Application;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazorBootstrap();
builder.Services.AddApplication();

await builder.Build().RunAsync();