using WeatherForecast.ViewModels;

namespace WeatherForecast;

public partial class MainPage : ContentPage
{
	private readonly MainPageViewModel _viewModel;

	public MainPage()
	{
		InitializeComponent();

		if (BindingContext is not MainPageViewModel viewModel) throw new Exception("BindingContext must be of type MainPageViewModel");
		_viewModel = viewModel;
	}
}

