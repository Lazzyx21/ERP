using ERP.Services;
using ERP.Shared.Services;
using Microsoft.Extensions.Logging;

namespace ERP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Add device-specific services used by the ERP.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddScoped<ManufacturingApiService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/bomlistreponse") });

            builder.Services.AddScoped<ProductsApiService>();
            builder.Services.AddScoped(pp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/PList") });
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}