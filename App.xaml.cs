using WeatherForecast.Tools;

namespace WeatherForecast;

public partial class App : Application
{
	private readonly Env _env;
	
	public App(Env env)
	{
		_env = env;
		
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new MainPage(_env));
	}
}