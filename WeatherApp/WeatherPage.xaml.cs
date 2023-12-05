using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}
	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var result = await ApiService.GetWeather(25.03746, 121.564558);
		lblCity.Text = result.City.Name;
		weatherDescription.Text = result.List[0].Weather[0].Description;
	}
}