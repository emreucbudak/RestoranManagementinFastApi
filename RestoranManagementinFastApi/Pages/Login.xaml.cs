namespace RestoranManagementinFastApi.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
	private async void OnBackButtonClicked (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///MainPage");
	}
	private async void onLoginClicked (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///RestaurantManagerPanel");
	}
}