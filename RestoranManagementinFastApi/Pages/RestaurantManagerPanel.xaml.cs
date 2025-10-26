namespace RestoranManagementinFastApi.Pages;

public partial class RestaurantManagerPanel : ContentPage
{
	public RestaurantManagerPanel()
	{
		InitializeComponent();
	}
	private async void OnProductManagementTransfer (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///ProductPanel");
	}
}