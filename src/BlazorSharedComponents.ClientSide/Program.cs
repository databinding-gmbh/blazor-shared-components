using System.Threading.Tasks;
using BlazorSharedComponents.Lib;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorSharedComponents.ClientSide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddScoped<IInjectableCustomService, InjectableCustomService>();

            await builder.Build().RunAsync();
        }
    }
}
