using CvPortfolio.Core.Services;
using CvPortfolio.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<ICvService, CvService>();
builder.Services.AddSingleton<ILanguageService, LanguageService>();

await builder.Build().RunAsync();
