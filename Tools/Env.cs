namespace WeatherForecast.Tools;

public class Env(IDictionary<string, string> variables)
{
	private readonly Dictionary<string, string> _variables = variables.ToDictionary();
	
	public string Get(string key) => _variables[key];
}