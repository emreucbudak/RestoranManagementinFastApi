namespace RestoranManagementinFastApi.Pages;

public partial class WaiterLogin : ContentPage
{
	public WaiterLogin()
	{
		InitializeComponent();
	}
	private async void OnBackButtonClicked (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///MainPage");

	}
}