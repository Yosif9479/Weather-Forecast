using dotenv.net;
using WeatherForecast.Constants;
using WeatherForecast.Tools;

namespace WeatherForecast;

public static class StartupExtensions
{
	public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
	{
		DotEnv.Load();

		IDictionary<string, string> envVariables = DotEnv.Read();
		
		builder.Services.AddSingleton(new Env(envVariables));
		
		return builder;
	}
	public static MauiAppBuilder AddFonts(this MauiAppBuilder app)
	{
		app.ConfigureFonts(fonts =>
		{
			foreach (var alias in FontConstants.FontAliases)
			{
				fonts.AddFont(alias.Key, alias.Value);
			}
		});
		
		return app;
	}
}