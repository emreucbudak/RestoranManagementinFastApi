namespace RestoranManagementinFastApi.Pages;

public partial class WaiterManagementPanel : ContentPage
{
	public WaiterManagementPanel()
	{
		InitializeComponent();
	}
	private async void OnBackButtonClicked (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///RestaurantManagerPanel");
	}
}