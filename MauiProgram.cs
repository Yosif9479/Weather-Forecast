using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace WeatherForecast;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Montserrat-Bold.ttf", "Montserrat-Bold");
				fonts.AddFont("Montserrat-Medium.ttf", "Montserrat-Medium");
			});

		#if DEBUG
		builder.Logging.AddDebug();
		#endif

		return builder.Build();
	}
}