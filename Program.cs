using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PruebaNet8_BlazorServer_AndresCueva;
using PruebaNet8_BlazorServer_AndresCueva.Data;
using PruebaNet8_BlazorServer_AndresCueva.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// ConfigurationServices()
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDbContext<EmpleadoContext>();//new lines, para la inject de las dependencias.
builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();

await builder.Build().RunAsync();
