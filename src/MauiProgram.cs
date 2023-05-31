using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

namespace Clippy
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                });
// #if DEBUG
//             builder.Logging.AddDebug();
// #endif
            builder.Logging.AddDebug();
            builder.Logging.SetMinimumLevel(LogLevel.Debug);
            // Register the INavigationService and NavigationService
            return builder.Build();
        }
        // static void ConfigureServices(IServiceCollection services)
        // {
        //     // services.AddSingleton<IClipboardService, ClipboardService>();
        //     // services.AddSingleton<INavigationService, NavigationService>();
        //     services.AddSingleton<ILogger, Logger>();
        // }
    }
}
