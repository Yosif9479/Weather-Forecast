using Microsoft.Extensions.Logging;

namespace WeatherForecast;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		MauiAppBuilder builder = MauiApp.CreateBuilder();
		
		builder.UseMauiApp<App>()
			.AddFonts()
			.AddServices();

		#if DEBUG
		builder.Logging.AddDebug();
		#endif

		return builder.Build();
	}
}