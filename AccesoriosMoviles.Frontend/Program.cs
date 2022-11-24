using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using AccesoriosMoviles.Frontend.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AccesoriosMoviles.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.accesorios.somee.com/api/") });

            

            builder.Services.AddMudServices(); //importacion de los servicios de Mudblazor

            builder.Services.AddScoped<UserAuth>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync();
        }
    }
}
